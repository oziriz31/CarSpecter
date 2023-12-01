namespace CarSpecter.Options
{
    public class NHTSApiOptions
    {
        public const string NHTSAWebApiSettings = "NHTSAWebApiSettings";

        public string BaseAddress { get; set; } = string.Empty;
        public string DefaultResponseFormat { get; set; } = string.Empty;
    }
}
