// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Tools.Properties
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Tools.Properties.Resources", typeof(Resources).Assembly);

        /// <summary>
        ///     The assembly to use. Required.
        /// </summary>
        public static string AssemblyDescription
            => GetString("AssemblyDescription");

        /// <summary>
        ///     The connection string to the database.
        /// </summary>
        public static string ConnectionDescription
            => GetString("ConnectionDescription");

        /// <summary>
        ///     The DbContext to use.
        /// </summary>
        public static string ContextDescription
            => GetString("ContextDescription");

        /// <summary>
        ///     The directory to put the DbContext file in. Paths are relative to the project directory.
        /// </summary>
        public static string ContextDirDescription
            => GetString("ContextDirDescription");

        /// <summary>
        ///     The name of the DbContext. Defaults to the database name.
        /// </summary>
        public static string ContextNameDescription
            => GetString("ContextNameDescription");

        /// <summary>
        ///     The namespace of the DbContext class. Matches the directory by default.
        /// </summary>
        public static string ContextNamespaceDescription
            => GetString("ContextNamespaceDescription");

        /// <summary>
        ///     Use attributes to configure the model (where possible). If omitted, only the fluent API is used.
        /// </summary>
        public static string DataAnnotationsDescription
            => GetString("DataAnnotationsDescription");

        /// <summary>
        ///     Commands to manage the database.
        /// </summary>
        public static string DatabaseDescription
            => GetString("DatabaseDescription");

        /// <summary>
        ///     Drops the database.
        /// </summary>
        public static string DatabaseDropDescription
            => GetString("DatabaseDropDescription");

        /// <summary>
        ///     This would drop the database '{database}' on server '{dataSource}'.
        /// </summary>
        public static string DatabaseDropDryRun([CanBeNull] object? database, [CanBeNull] object? dataSource)
            => string.Format(
                GetString("DatabaseDropDryRun", nameof(database), nameof(dataSource)),
                database, dataSource);

        /// <summary>
        ///     Show which database would be dropped, but don't drop it.
        /// </summary>
        public static string DatabaseDropDryRunDescription
            => GetString("DatabaseDropDryRunDescription");

        /// <summary>
        ///     Don't confirm.
        /// </summary>
        public static string DatabaseDropForceDescription
            => GetString("DatabaseDropForceDescription");

        /// <summary>
        ///     Are you sure you want to drop the database '{database}' on server '{dataSource}'? (y/N)
        /// </summary>
        public static string DatabaseDropPrompt([CanBeNull] object? database, [CanBeNull] object? dataSource)
            => string.Format(
                GetString("DatabaseDropPrompt", nameof(database), nameof(dataSource)),
                database, dataSource);

        /// <summary>
        ///     Database name: {database}
        /// </summary>
        public static string DatabaseName([CanBeNull] object? database)
            => string.Format(
                GetString("DatabaseName", nameof(database)),
                database);

        /// <summary>
        ///     Updates the database to a specified migration.
        /// </summary>
        public static string DatabaseUpdateDescription
            => GetString("DatabaseUpdateDescription");

        /// <summary>
        ///     The data directory.
        /// </summary>
        public static string DataDirDescription
            => GetString("DataDirDescription");

        /// <summary>
        ///     Data source: {dataSource}
        /// </summary>
        public static string DataSource([CanBeNull] object? dataSource)
            => string.Format(
                GetString("DataSource", nameof(dataSource)),
                dataSource);

        /// <summary>
        ///     The connection string to the database. Defaults to the one specified in AddDbContext or OnConfiguring.
        /// </summary>
        public static string DbContextConnectionDescription
            => GetString("DbContextConnectionDescription");

        /// <summary>
        ///     Commands to manage DbContext types.
        /// </summary>
        public static string DbContextDescription
            => GetString("DbContextDescription");

        /// <summary>
        ///     Gets information about a DbContext type.
        /// </summary>
        public static string DbContextInfoDescription
            => GetString("DbContextInfoDescription");

        /// <summary>
        ///     Lists available DbContext types.
        /// </summary>
        public static string DbContextListDescription
            => GetString("DbContextListDescription");

        /// <summary>
        ///     Scaffolds a DbContext and entity types for a database.
        /// </summary>
        public static string DbContextScaffoldDescription
            => GetString("DbContextScaffoldDescription");

        /// <summary>
        ///     Overwrite existing files.
        /// </summary>
        public static string DbContextScaffoldForceDescription
            => GetString("DbContextScaffoldForceDescription");

        /// <summary>
        ///     Generates a SQL script from the DbContext. Bypasses any migrations.
        /// </summary>
        public static string DbContextScriptDescription
            => GetString("DbContextScriptDescription");

        /// <summary>
        ///     Your startup project '{startupProject}' doesn't reference Microsoft.EntityFrameworkCore.Design. This package is required for the Entity Framework Core Tools to work. Ensure your startup project is correct, install the package, and try again.
        /// </summary>
        public static string DesignNotFound([CanBeNull] object? startupProject)
            => string.Format(
                GetString("DesignNotFound", nameof(startupProject)),
                startupProject);

        /// <summary>
        ///     Entity Framework Core Command-line Tools
        /// </summary>
        public static string EFFullName
            => GetString("EFFullName");

        /// <summary>
        ///     Generate a script that can be used on a database at any migration.
        /// </summary>
        public static string IdempotentDescription
            => GetString("IdempotentDescription");

        /// <summary>
        ///     Invalid template pattern '{template}'.
        /// </summary>
        public static string InvalidTemplatePattern([CanBeNull] object? template)
            => string.Format(
                GetString("InvalidTemplatePattern", nameof(template)),
                template);

        /// <summary>
        ///     Show JSON output. Use with --prefix-output to parse programatically.
        /// </summary>
        public static string JsonDescription
            => GetString("JsonDescription");

        /// <summary>
        ///     The language. Defaults to 'C#'.
        /// </summary>
        public static string LanguageDescription
            => GetString("LanguageDescription");

        /// <summary>
        ///     The last argument '{argumentName}' accepts multiple values. No more argument can be added.
        /// </summary>
        public static string LastArgumentHasMultipleValues([CanBeNull] object? argumentName)
            => string.Format(
                GetString("LastArgumentHasMultipleValues", nameof(argumentName)),
                argumentName);

        /// <summary>
        ///     The target migration. If '0', all migrations will be reverted. Defaults to the last migration.
        /// </summary>
        public static string MigrationDescription
            => GetString("MigrationDescription");

        /// <summary>
        ///     The starting migration. Defaults to '0' (the initial database).
        /// </summary>
        public static string MigrationFromDescription
            => GetString("MigrationFromDescription");

        /// <summary>
        ///     The name of the migration.
        /// </summary>
        public static string MigrationNameDescription
            => GetString("MigrationNameDescription");

        /// <summary>
        ///     Done. To undo this action, use 'ef migrations remove'
        /// </summary>
        public static string MigrationsAddCompleted
            => GetString("MigrationsAddCompleted");

        /// <summary>
        ///     Adds a new migration.
        /// </summary>
        public static string MigrationsAddDescription
            => GetString("MigrationsAddDescription");

        /// <summary>
        ///     Commands to manage migrations.
        /// </summary>
        public static string MigrationsDescription
            => GetString("MigrationsDescription");

        /// <summary>
        ///     Lists available migrations.
        /// </summary>
        public static string MigrationsListDescription
            => GetString("MigrationsListDescription");

        /// <summary>
        ///     The namespace to use. Matches the directory by default.
        /// </summary>
        public static string MigrationsNamespaceDescription
            => GetString("MigrationsNamespaceDescription");

        /// <summary>
        ///     The directory to put files in. Paths are relative to the project directory. Defaults to "Migrations".
        /// </summary>
        public static string MigrationsOutputDirDescription
            => GetString("MigrationsOutputDirDescription");

        /// <summary>
        ///     Removes the last migration.
        /// </summary>
        public static string MigrationsRemoveDescription
            => GetString("MigrationsRemoveDescription");

        /// <summary>
        ///     Revert the migration if it has been applied to the database.
        /// </summary>
        public static string MigrationsRemoveForceDescription
            => GetString("MigrationsRemoveForceDescription");

        /// <summary>
        ///     Generates a SQL script from migrations.
        /// </summary>
        public static string MigrationsScriptDescription
            => GetString("MigrationsScriptDescription");

        /// <summary>
        ///     The target migration. Defaults to the last migration.
        /// </summary>
        public static string MigrationToDescription
            => GetString("MigrationToDescription");

        /// <summary>
        ///     Missing required argument '{arg}'.
        /// </summary>
        public static string MissingArgument([CanBeNull] object? arg)
            => string.Format(
                GetString("MissingArgument", nameof(arg)),
                arg);

        /// <summary>
        ///     Missing required option '--{option}'.
        /// </summary>
        public static string MissingOption([CanBeNull] object? option)
            => string.Format(
                GetString("MissingOption", nameof(option)),
                option);

        /// <summary>
        ///     The namespace to use. Matches the directory by default.
        /// </summary>
        public static string NamespaceDescription
            => GetString("NamespaceDescription");

        /// <summary>
        ///     Don't colorize output.
        /// </summary>
        public static string NoColorDescription
            => GetString("NoColorDescription");

        /// <summary>
        ///     Don't connect to the database.
        /// </summary>
        public static string NoConnectDescription
            => GetString("NoConnectDescription");

        /// <summary>
        ///     No DbContext was found.
        /// </summary>
        public static string NoDbContext
            => GetString("NoDbContext");

        /// <summary>
        ///     No migrations were found.
        /// </summary>
        public static string NoMigrations
            => GetString("NoMigrations");

        /// <summary>
        ///     Don't use the pluralizer.
        /// </summary>
        public static string NoPluralizeDescription
            => GetString("NoPluralizeDescription");

        /// <summary>
        ///     Don't generate SQL transaction statements.
        /// </summary>
        public static string NoTransactionsDescription
            => GetString("NoTransactionsDescription");

        /// <summary>
        ///     Options: {options}
        /// </summary>
        public static string Options([CanBeNull] object? options)
            => string.Format(
                GetString("Options", nameof(options)),
                options);

        /// <summary>
        ///     The file to write the result to.
        /// </summary>
        public static string OutputDescription
            => GetString("OutputDescription");

        /// <summary>
        ///     The directory to put files in. Paths are relative to the project directory.
        /// </summary>
        public static string OutputDirDescription
            => GetString("OutputDirDescription");

        /// <summary>
        ///      (Pending)
        /// </summary>
        public static string Pending
            => GetString("Pending");

        /// <summary>
        ///     Prefix output with level.
        /// </summary>
        public static string PrefixDescription
            => GetString("PrefixDescription");

        /// <summary>
        ///     The project directory. Defaults to the current working directory.
        /// </summary>
        public static string ProjectDirDescription
            => GetString("ProjectDirDescription");

        /// <summary>
        ///     The provider to use. (E.g. Microsoft.EntityFrameworkCore.SqlServer)
        /// </summary>
        public static string ProviderDescription
            => GetString("ProviderDescription");

        /// <summary>
        ///     Provider name: {provider}
        /// </summary>
        public static string ProviderName([CanBeNull] object? provider)
            => string.Format(
                GetString("ProviderName", nameof(provider)),
                provider);

        /// <summary>
        ///     Remaining arguments: {remainingArguments}.
        /// </summary>
        public static string RemainingArguments([CanBeNull] object? remainingArguments)
            => string.Format(
                GetString("RemainingArguments", nameof(remainingArguments)),
                remainingArguments);

        /// <summary>
        ///     Response file '{fileName}' doesn't exist.
        /// </summary>
        public static string ResponseFileMissing([CanBeNull] object? fileName)
            => string.Format(
                GetString("ResponseFileMissing", nameof(fileName)),
                fileName);

        /// <summary>
        ///     The root namespace. Defaults to the target assembly name.
        /// </summary>
        public static string RootNamespaceDescription
            => GetString("RootNamespaceDescription");

        /// <summary>
        ///     The schemas of tables to generate entity types for.
        /// </summary>
        public static string SchemasDescription
            => GetString("SchemasDescription");

        /// <summary>
        ///     The startup assembly to use. Defaults to the target assembly.
        /// </summary>
        public static string StartupAssemblyDescription
            => GetString("StartupAssemblyDescription");

        /// <summary>
        ///     Don't generate DbContext.OnConfiguring.
        /// </summary>
        public static string SuppressOnConfiguringDescription
            => GetString("SuppressOnConfiguringDescription");

        /// <summary>
        ///     The tables to generate entity types for.
        /// </summary>
        public static string TablesDescription
            => GetString("TablesDescription");

        /// <summary>
        ///     Unrecognized {argumentName} '{argumentValue}'.
        /// </summary>
        public static string UnexpectedArgument([CanBeNull] object? argumentName, [CanBeNull] object? argumentValue)
            => string.Format(
                GetString("UnexpectedArgument", nameof(argumentName), nameof(argumentValue)),
                argumentName, argumentValue);

        /// <summary>
        ///     Unexpected value '{optionValue}' for option '{optionName}'.
        /// </summary>
        public static string UnexpectedOptionValue([CanBeNull] object? optionValue, [CanBeNull] object? optionName)
            => string.Format(
                GetString("UnexpectedOptionValue", nameof(optionValue), nameof(optionName)),
                optionValue, optionName);

        /// <summary>
        ///     Use table and column names directly from the database.
        /// </summary>
        public static string UseDatabaseNamesDescription
            => GetString("UseDatabaseNamesDescription");

        /// <summary>
        ///     Using application base '{appBase}'.
        /// </summary>
        public static string UsingApplicationBase([CanBeNull] object? appBase)
            => string.Format(
                GetString("UsingApplicationBase", nameof(appBase)),
                appBase);

        /// <summary>
        ///     Using assembly '{assembly}'.
        /// </summary>
        public static string UsingAssembly([CanBeNull] object? assembly)
            => string.Format(
                GetString("UsingAssembly", nameof(assembly)),
                assembly);

        /// <summary>
        ///     Using configuration file '{config}'.
        /// </summary>
        public static string UsingConfigurationFile([CanBeNull] object? config)
            => string.Format(
                GetString("UsingConfigurationFile", nameof(config)),
                config);

        /// <summary>
        ///     Using data directory '{dataDir}'.
        /// </summary>
        public static string UsingDataDir([CanBeNull] object? dataDir)
            => string.Format(
                GetString("UsingDataDir", nameof(dataDir)),
                dataDir);

        /// <summary>
        ///     Using project directory '{projectDir}'.
        /// </summary>
        public static string UsingProjectDir([CanBeNull] object? projectDir)
            => string.Format(
                GetString("UsingProjectDir", nameof(projectDir)),
                projectDir);

        /// <summary>
        ///     Using root namespace '{rootNamespace}'.
        /// </summary>
        public static string UsingRootNamespace([CanBeNull] object? rootNamespace)
            => string.Format(
                GetString("UsingRootNamespace", nameof(rootNamespace)),
                rootNamespace);

        /// <summary>
        ///     Using startup assembly '{startupAssembly}'.
        /// </summary>
        public static string UsingStartupAssembly([CanBeNull] object? startupAssembly)
            => string.Format(
                GetString("UsingStartupAssembly", nameof(startupAssembly)),
                startupAssembly);

        /// <summary>
        ///     Using working directory '{workingDirectory}'.
        /// </summary>
        public static string UsingWorkingDirectory([CanBeNull] object? workingDirectory)
            => string.Format(
                GetString("UsingWorkingDirectory", nameof(workingDirectory)),
                workingDirectory);

        /// <summary>
        ///     Show verbose output.
        /// </summary>
        public static string VerboseDescription
            => GetString("VerboseDescription");

        /// <summary>
        ///     The working directory of the tool invoking this command.
        /// </summary>
        public static string WorkingDirDescription
            => GetString("WorkingDirDescription");

        /// <summary>
        ///     Writing '{file}'...
        /// </summary>
        public static string WritingFile([CanBeNull] object? file)
            => string.Format(
                GetString("WritingFile", nameof(file)),
                file);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name)!;
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

