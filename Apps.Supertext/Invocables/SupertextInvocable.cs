using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.Supertext.Invocables;

public class SupertextInvocable : BaseInvocable
{
    protected AuthenticationCredentialsProvider[] Creds =>
        InvocationContext.AuthenticationCredentialsProviders.ToArray();
    
    protected SupertextClient Client { get; }
    
    public SupertextInvocable(InvocationContext invocationContext) : base(invocationContext)
    {
        Client = new();
    }
}