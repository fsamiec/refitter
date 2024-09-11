using System.ComponentModel;

using Refitter.Core;

using Spectre.Console.Cli;

namespace Refitter;

public sealed class Settings : CommandSettings
{
    public const string DefaultOutputPath = "Output.cs";

    [Description("URL or file path to OpenAPI Specification file")]
    [CommandArgument(0, "[URL or input file]")]
    [DefaultValue(null)]
    public string? OpenApiPath { get; set; }

    [Description("Path to .refitter settings file. Specifying this will ignore all other settings (except for --output)")]
    [CommandOption("-s|--settings-file")]
    public string? SettingsFilePath { get; set; }

    [Description("Default namespace to use for generated types")]
    [CommandOption("-n|--namespace")]
    [DefaultValue("GeneratedCode")]
    public string? Namespace { get; set; }

    [Description("Default namespace to use for generated contracts")]
    [CommandOption("--contracts-namespace")]
    [DefaultValue(null)]
    public string? ContractsNamespace { get; set; }

    [Description("Path to Output file or folder (if multiple files are generated)")]
    [CommandOption("-o|--output")]
    [DefaultValue(DefaultOutputPath)]
    public string? OutputPath { get; set; }

    [Description("Output path for generated contracts. Enabling this automatically enables generating multiple files")]
    [CommandOption("--contracts-output")]
    [DefaultValue(null)]
    public string? ContractsOutputPath { get; set; }

    [Description("Don't add <auto-generated> header to output file")]
    [CommandOption("--no-auto-generated-header")]
    [DefaultValue(false)]
    public bool NoAutoGeneratedHeader { get; set; }

    [Description("Don't add <Accept> header to output file")]
    [CommandOption("--no-accept-headers")]
    [DefaultValue(false)]
    public bool NoAcceptHeaders { get; set; }

    [Description("Don't generate contract types")]
    [CommandOption("--interface-only")]
    [DefaultValue(false)]
    public bool InterfaceOnly { get; set; }

    [Description("Don't generate clients")]
    [CommandOption("--contract-only")]
    [DefaultValue(false)]
    public bool ContractOnly { get; set; }

    [Description("Return Task<IApiResponse<T>> instead of Task<T>")]
    [CommandOption("--use-api-response")]
    [DefaultValue(false)]
    public bool ReturnIApiResponse { get; set; }

    [Description("Return IObservable instead of Task")]
    [CommandOption("--use-observable-response")]
    [DefaultValue(false)]
    public bool ReturnIObservable { get; set; }

    [Description("Set the accessibility of the generated types to 'internal'")]
    [CommandOption("--internal")]
    [DefaultValue(false)]
    public bool InternalTypeAccessibility { get; set; }

    [Description("Use cancellation tokens")]
    [CommandOption("--cancellation-tokens")]
    [DefaultValue(false)]
    public bool UseCancellationTokens { get; set; }

    [Description("Don't generate operation headers")]
    [CommandOption("--no-operation-headers")]
    [DefaultValue(false)]
    public bool NoOperationHeaders { get; set; }

    [Description("Don't log errors or collect telemetry")]
    [CommandOption("--no-logging")]
    [DefaultValue(false)]
    public bool NoLogging { get; set; }

    [Description("Add additional namespace to generated types")]
    [CommandOption("--additional-namespace")]
    [DefaultValue(new string[0])]
    public string[]? AdditionalNamespaces { get; set; }

    [Description("Exclude namespace on generated types")]
    [CommandOption("--exclude-namespace")]
    [DefaultValue(new string[0])]
    public string[]? ExcludeNamespaces { get; set; }

    [Description("Explicitly format date query string parameters in ISO 8601 standard date format using delimiters (2023-06-15)")]
    [CommandOption("--use-iso-date-format")]
    [DefaultValue(false)]
    public bool UseIsoDateFormat { get; set; }

    private const string MultipleInterfacesValues = $"{nameof(Core.MultipleInterfaces.ByEndpoint)}, {nameof(Core.MultipleInterfaces.ByTag)}";

    [Description($"Generate a Refit interface for each endpoint. May be one of {MultipleInterfacesValues}")]
    [CommandOption("--multiple-interfaces")]
    public Core.MultipleInterfaces MultipleInterfaces { get; set; } = Core.MultipleInterfaces.Unset;

    [Description("""
                 Generate multiple files instead of a single large file. 
                 The output files can be the following:
                 - RefitInterfaces.cs
                 - DependencyInjection.cs
                 - Contracts.cs
                 """)]
    [CommandOption("--multiple-files")]
    [DefaultValue(false)]
    public bool GenerateMultipleFiles { get; set; }

    [Description("Only include Paths that match the provided regular expression. May be set multiple times.")]
    [CommandOption("--match-path")]
    [DefaultValue(new string[0])]
    public string[]? MatchPaths { get; set; }

    [Description("Only include Endpoints that contain this tag. May be set multiple times and result in OR'ed evaluation.")]
    [CommandOption("--tag")]
    [DefaultValue(new string[0])]
    public string[]? Tags { get; set; }

    [Description("Skip validation of the OpenAPI specification")]
    [CommandOption("--skip-validation")]
    public bool SkipValidation { get; set; }

    [Description("Don't generate deprecated operations")]
    [CommandOption("--no-deprecated-operations")]
    [DefaultValue(false)]
    public bool NoDeprecatedOperations { get; set; }

    [Description("Generate operation names using pattern. When using --multiple-interfaces ByEndpoint, this is name of the Execute() method in the interface.")]
    [CommandOption("--operation-name-template")]
    [DefaultValue(null)]
    public string? OperationNameTemplate { get; internal set; }

    [Description("Generate nullable parameters as optional parameters")]
    [CommandOption("--optional-nullable-parameters")]
    [DefaultValue(false)]
    public bool OptionalNullableParameters { get; set; }

    [Description("Removes unreferenced components schema to keep the generated output to a minimum")]
    [CommandOption("--trim-unused-schema")]
    [DefaultValue(false)]
    public bool TrimUnusedSchema { get; set; }

    [Description("Force to keep matching schema, uses regular expressions. Use together with \"--trim-unused-schema\". Can be set multiple times.")]
    [CommandOption("--keep-schema")]
    [DefaultValue(new string[0])]
    public string[]? KeepSchemaPatterns { get; set; }

    [Description("Don't show donation banner")]
    [CommandOption("--no-banner")]
    [DefaultValue(false)]
    public bool NoBanner { get; set; }

    [Description("Set to true to skip default additional properties")]
    [CommandOption("--skip-default-additional-properties")]
    [DefaultValue(false)]
    public bool SkipDefaultAdditionalProperties { get; set; }

    [Description("""
                 The NSwag IOperationNameGenerator implementation to use. 
                 May be one of: 
                 - Default
                 - MultipleClientsFromOperationId
                 - MultipleClientsFromPathSegments
                 - MultipleClientsFromFirstTagAndOperationId
                 - MultipleClientsFromFirstTagAndOperationName
                 - MultipleClientsFromFirstTagAndPathSegments
                 - SingleClientFromOperationId
                 - SingleClientFromPathSegments
                 See https://refitter.github.io/api/Refitter.Core.OperationNameGeneratorTypes.html for more information.
                 """)]
    [CommandOption("--operation-name-generator")]
    [DefaultValue(OperationNameGeneratorTypes.Default)]
    public OperationNameGeneratorTypes OperationNameGenerator { get; set; }

    [Description("Generate contracts as immutable records instead of classes")]
    [CommandOption("--immutable-records")]
    [DefaultValue(false)]
    public bool ImmutableRecords { get; set; }

    [Description("""
                 Set to true to use Apizr by:
                 - Adding a final IApizrRequestOptions options parameter to all generated methods
                 - Providing cancellation tokens by Apizr request options instead of a dedicated parameter
                 - Using method overloads instead of optional parameters
                 See https://refitter.github.io for more information and https://www.apizr.net to get started with Apizr.
                 """)]
    [CommandOption("--use-apizr")]
    [DefaultValue(false)]
    public bool UseApizr { get; set; }

    [Description("""
                 Set to <c>true</c> to wrap multiple query parameters into a single complex one. Default is <c>false</c> (no wrapping).
                 See https://github.com/reactiveui/refit?tab=readme-ov-file#dynamic-querystring-parameters for more information.
                 """)]
    [CommandOption("--use-dynamic-querystring-parameters")]
    [DefaultValue(false)]
    public bool UseDynamicQuerystringParameters { get; set; }

    [Description("Use System.Text.Json polymorphic serialization.")]
    [CommandOption("--use-polymorphic-serialization")]
    [DefaultValue(false)]
    public bool UsePolymorphicSerialization { get; set; }
}
