namespace Finalist.Serialization.JsonNet
{
    using Newtonsoft.Json;

    public static class JsonNetExtensions
    {
        public static JsonSerializerSettings ConfigureFinalList(this JsonSerializerSettings settings)
        {
            settings.Converters.Add(new FinalListConverter());

            return settings;
        }

        public static JsonSerializer ConfigureFinalList(this JsonSerializer serializer)
        {
            serializer.Converters.Add(new FinalListConverter());

            return serializer;
        }
    }
}
