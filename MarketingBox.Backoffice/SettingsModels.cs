using MyYamlParser;

namespace MarketingBox.Backoffice
{
    public class SettingsModel
    {
        [YamlProperty("MarketingBoxBackOffice.TableStorageConnectionString")]
        public string TableStorageConnectionString { get; set; }

        [YamlProperty("MarketingBoxBackOffice.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("MarketingBoxBackOffice.ZipkinUrl")]
        public string ZipkinUrl { get; set; }
    }
}