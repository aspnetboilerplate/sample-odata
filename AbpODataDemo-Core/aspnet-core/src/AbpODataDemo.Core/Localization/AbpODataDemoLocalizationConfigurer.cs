using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpODataDemo.Localization
{
    public static class AbpODataDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpODataDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpODataDemoLocalizationConfigurer).GetAssembly(),
                        "AbpODataDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
