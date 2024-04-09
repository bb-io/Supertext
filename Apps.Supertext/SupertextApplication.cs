using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Metadata;

namespace Apps.Supertext;

public class SupertextApplication : IApplication, ICategoryProvider
{
    public IEnumerable<ApplicationCategory> Categories
    {
        get => [ApplicationCategory.LspPortal];
        set { }
    }
    
    public string Name
    {
        get => "Supertext";
        set { }
    }

    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}