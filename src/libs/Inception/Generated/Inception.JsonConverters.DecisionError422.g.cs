#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Inception.JsonConverters
{
    /// <inheritdoc />
    public class DecisionError422JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inception.DecisionError422>
    {
        /// <inheritdoc />
        public override global::Inception.DecisionError422 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("detail")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("error")) __score1++;
            if (__jsonProps.Contains("error.code")) __score1++;
            if (__jsonProps.Contains("error.message")) __score1++;
            if (__jsonProps.Contains("error.param")) __score1++;
            if (__jsonProps.Contains("error.type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Inception.HTTPValidationError? hTTPValidationError = default;
            global::Inception.DecisionUpstreamValidationError? decisionUpstreamValidationError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.HTTPValidationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.HTTPValidationError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.HTTPValidationError).Name}");
                        hTTPValidationError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.DecisionUpstreamValidationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.DecisionUpstreamValidationError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.DecisionUpstreamValidationError).Name}");
                        decisionUpstreamValidationError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (hTTPValidationError == null && decisionUpstreamValidationError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.HTTPValidationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.HTTPValidationError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.HTTPValidationError).Name}");
                    hTTPValidationError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (hTTPValidationError == null && decisionUpstreamValidationError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.DecisionUpstreamValidationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.DecisionUpstreamValidationError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.DecisionUpstreamValidationError).Name}");
                    decisionUpstreamValidationError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Inception.DecisionError422(
                hTTPValidationError,

                decisionUpstreamValidationError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inception.DecisionError422 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHTTPValidationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.HTTPValidationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.HTTPValidationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.HTTPValidationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHTTPValidationError(), typeInfo);
            }
            else if (value.IsDecisionUpstreamValidationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.DecisionUpstreamValidationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.DecisionUpstreamValidationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.DecisionUpstreamValidationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionUpstreamValidationError(), typeInfo);
            }
        }
    }
}