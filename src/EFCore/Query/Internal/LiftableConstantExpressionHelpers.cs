﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.Query.Internal;

/// <summary>
///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
///     the same compatibility standards as public APIs. It may be changed or removed without notice in
///     any release. You should only use it directly in your code with extreme caution and knowing that
///     doing so can result in application failures when updating to a new Entity Framework Core release.
/// </summary>
public class LiftableConstantExpressionHelpers
{
    private static readonly MethodInfo ModelFindEntiyTypeMethod =
        typeof(IModel).GetRuntimeMethod(nameof(IModel.FindEntityType), [typeof(string)])!;

    private static readonly MethodInfo RuntimeModelFindAdHocEntiyTypeMethod =
        typeof(RuntimeModel).GetRuntimeMethod(nameof(RuntimeModel.FindAdHocEntityType), [typeof(string)])!;

    private static readonly MethodInfo TypeBaseFindComplexPropertyMethod =
        typeof(ITypeBase).GetRuntimeMethod(nameof(ITypeBase.FindComplexProperty), [typeof(string)])!;

    private static readonly MethodInfo TypeBaseFindPropertyMethod =
        typeof(ITypeBase).GetRuntimeMethod(nameof(ITypeBase.FindProperty), [typeof(string)])!;

    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static Expression BuildMemberAccessForEntityOrComplexType(ITypeBase targetType, ParameterExpression liftableConstantContextParameter)
    {
        var (rootEntityType, complexTypes) = FindPathForEntityOrComplexType(targetType);

        Expression result;

        // TODO: surely, there is a better way?
        if (rootEntityType.Model is RuntimeModel runtimeModel
            && runtimeModel.FindAdHocEntityType(rootEntityType.ClrType) == rootEntityType)
        {
            result = Expression.Call(
                Expression.Convert(
                    Expression.Property(
                        Expression.Property(
                            liftableConstantContextParameter,
                            nameof(MaterializerLiftableConstantContext.Dependencies)),
                        nameof(ShapedQueryCompilingExpressionVisitorDependencies.Model)),
                    typeof(RuntimeModel)),
                RuntimeModelFindAdHocEntiyTypeMethod,
                Expression.Constant(rootEntityType.Name));
        }
        else
        {
            result = Expression.Call(
                Expression.Property(
                    Expression.Property(
                        liftableConstantContextParameter,
                        nameof(MaterializerLiftableConstantContext.Dependencies)),
                    nameof(ShapedQueryCompilingExpressionVisitorDependencies.Model)),
                ModelFindEntiyTypeMethod,
                Expression.Constant(rootEntityType.Name));
        }

        foreach (var complexType in complexTypes)
        {
            var complexPropertyName = complexType.ComplexProperty.Name;
            result = Expression.Property(
                Expression.Call(result, TypeBaseFindComplexPropertyMethod, Expression.Constant(complexPropertyName)),
                nameof(IComplexProperty.ComplexType));
        }

        return result;
    }

    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static Expression BuildMemberAccessForProperty(IPropertyBase property, ParameterExpression liftableConstantContextParameter)
    {
        var declaringType = property.DeclaringType;
        var declaringTypeMemberAccessExpression = BuildMemberAccessForEntityOrComplexType(declaringType, liftableConstantContextParameter);

        return Expression.Call(
            declaringTypeMemberAccessExpression,
            TypeBaseFindPropertyMethod,
            Expression.Constant(property.Name));
    }

    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static Expression<Func<MaterializerLiftableConstantContext, object>> BuildMemberAccessLambdaForEntityOrComplexType(ITypeBase type)
    {
        var prm = Expression.Parameter(typeof(MaterializerLiftableConstantContext));
        var body = BuildMemberAccessForEntityOrComplexType(type, prm);

        return Expression.Lambda<Func<MaterializerLiftableConstantContext, object>>(body, prm);
    }

    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static Expression<Func<MaterializerLiftableConstantContext, object>> BuildMemberAccessLambdaForProperty(IPropertyBase property)
    {
        var prm = Expression.Parameter(typeof(MaterializerLiftableConstantContext));
        var body = BuildMemberAccessForProperty(property, prm);

        return Expression.Lambda<Func<MaterializerLiftableConstantContext, object>>(body, prm);
    }

    private static (IEntityType RootEntity, List<IComplexType> ComplexTypes) FindPathForEntityOrComplexType(ITypeBase targetType)
    {
        if (targetType is IEntityType targetEntity)
        {
            return (targetEntity, []);
        }

        var targetComplexType = (IComplexType)targetType;
        var declaringType = targetComplexType.ComplexProperty.DeclaringType;
        if (declaringType is IEntityType declaringEntityType)
        {
            return (declaringEntityType, [targetComplexType]);
        }

        var complexTypes = new List<IComplexType>();
        while (declaringType is IComplexType complexType)
        {
            complexTypes.Insert(0, complexType);
            declaringType = complexType.ComplexProperty.DeclaringType;
        }

        complexTypes.Add(targetComplexType);

        return ((IEntityType)declaringType, complexTypes);
    }
}