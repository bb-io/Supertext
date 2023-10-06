using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext
{
    public class SupertextApplication : IApplication
    {
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
}
