using NSwag;
using NSwag.CodeGeneration.TypeScript;
using System;
using System.IO;

namespace SwaggerTypeScriptGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var code = Generate();

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "ts.ts");
            using (var writer = File.CreateText(filePath)) {
                writer.WriteLine(code);
            }

            Console.WriteLine($"{filePath} - result here");
            Console.ReadKey();
        }

        private static string Generate()
        {
            const string SwaggerSpecUrl = "https://localhost:44376/swagger/v1/swagger.json";

            var document = OpenApiDocument.FromUrlAsync(SwaggerSpecUrl).Result;

            var settings = new TypeScriptClientGeneratorSettings
            {
                ClassName = "{controller}Client",
            };

            var generator = new TypeScriptClientGenerator(document, settings);
            return generator.GenerateFile();
        }
    }
}
