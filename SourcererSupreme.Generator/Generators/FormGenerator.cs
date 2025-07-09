using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using System.Text.Json;
using SourcererSupreme.Generator.Models;

namespace SourcererSupreme.Generator.Generators
{
    [Generator(LanguageNames.CSharp)] // Specify the language explicitly to avoid RS1041
    public class FormGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            // Register source generator for project configuration files
            var configFiles = context.AdditionalTextsProvider
                .Where(file => file.Path.EndsWith(".formconfig.json"));

            context.RegisterSourceOutput(configFiles, GenerateSource);
        }

        private void GenerateSource(SourceProductionContext context, AdditionalText configFile)
        {
            var json = configFile.GetText(context.CancellationToken)?.ToString();
            if (string.IsNullOrWhiteSpace(json))
                return;

            var config = JsonSerializer.Deserialize<ProjectConfiguration>(json);
            if (config == null)
                return;

            // Example: Generate a simple class for each form
            foreach (var form in config.Forms)
            {
                var source = $@"
    namespace Generated.Forms
    {{
        public class {form.Name}Form
        {{
            // Add properties and methods based on controls
        }}
    }}
    ";
                context.AddSource($"{form.Name}Form.g.cs", SourceText.From(source, Encoding.UTF8));
            }
        }
    }
}