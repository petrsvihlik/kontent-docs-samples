// DocSection: cm_api_v2_put_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

// Create a strongly typed model according to https://docs.kontent.ai/tutorials/develop-apps/get-content/using-strongly-typed-models?tech=dotnet
MyContentTypeModel stronglyTypedElements = new MyContentTypeModel
{
    Title = "En Asados",
    PostDate = new DateTime(2014, 11, 7),
    Summary = "Tostar granos de café puede tardar de 6 a 13 minutos. ...",
    RelatedArticles = new [] { ContentItemIdentifier.ByCodename("coffee_processing_techniques"), ContentItemIdentifier.ByCodename("origins_of_arabica_bourbon") },
    UrlPattern = "on-roasts",
    MetaKeywords = "asados, café",
    MetaDescription = "Tostar granos de café puede tardar de 6 a 13 minutos. ...",
    Personas = new [] { TaxonomyTermIdentifier.ByCodename("barista"), TaxonomyTermIdentifier.ByCodename("coffee_blogger") }
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByCodename("my_article");
// ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("59713");

LanguageIdentifier languageIdentifier = LanguageIdentifier.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8"));
// LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("es-ES");


ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<MyContentTypeModel> responseVariant = await client.UpsertContentItemVariantAsync<MyContentTypeModel>(identifier, stronglyTypedElements);
// EndDocSection