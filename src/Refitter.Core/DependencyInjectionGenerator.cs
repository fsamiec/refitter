﻿using System.Text;

namespace Refitter.Core;

public static class DependencyInjectionGenerator
{
    public static string Generate(
        RefitGeneratorSettings settings,
        string[] interfaceNames)
    {
        var iocSettings = settings.DependencyInjectionSettings;
        if (iocSettings is null || !interfaceNames.Any())
            return string.Empty;

        var code = new StringBuilder();

        code.AppendLine();
        code.AppendLine();
        code.AppendLine(
            $$""""
              namespace {{settings.Namespace}}
              {
                  using System;
                  using Microsoft.Extensions.DependencyInjection;
                  using Polly;
                  using Polly.Contrib.WaitAndRetry;
                  using Polly.Extensions.Http;

                  public static class IServiceCollectionExtensions
                  {
                      public static IServiceCollection ConfigureRefitClients(this IServiceCollection services)
                      {
              """");
        foreach (var interfaceName in interfaceNames)
        {
            code.Append(
                $$"""
                              services
                                  .AddRefitClient<{{interfaceName}}>()
                                  .ConfigureHttpClient(c => c.BaseAddress = new Uri("{{iocSettings.BaseUrl}}"))
                  """);

            foreach (string httpMessageHandler in iocSettings.HttpMessageHandlers)
            {
                code.AppendLine();
                code.Append($"                .AddHttpMessageHandler<{httpMessageHandler}>()");
            }

            if (iocSettings.UsePolly)
            {
                code.AppendLine();
                code.Append(
                    $$"""
                                      .AddPolicyHandler(
                                          HttpPolicyExtensions
                                              .HandleTransientHttpError()
                                              .WaitAndRetryAsync(
                                                  Backoff.DecorrelatedJitterBackoffV2(
                                                      TimeSpan.FromSeconds({{iocSettings.FirstBackoffRetryInSeconds}}),
                                                      {{iocSettings.PollyMaxRetryCount}}))
                      """);
            }

            code.Append(");");
            code.AppendLine();
            code.AppendLine();
        }
        
        code.Remove(code.Length - 2, 2);
        code.AppendLine();
        code.AppendLine("            return services;");
        code.AppendLine("        }");
        code.AppendLine("    }");
        code.AppendLine("}");
        code.AppendLine();
        return code.ToString();
    }
}