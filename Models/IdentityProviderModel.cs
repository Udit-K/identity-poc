namespace identity_poc.Models
{
    public class IdentityProviderModel 
    {
        public string IdentityProviderMetadataAddress { get; set;}
        public bool RequireValidMetadataSignature { get; set;}
        public ServiceProviderOptions ServiceProviderOptions { get; set;}
        public int TimeComparisonTolerance { get; set;}
        public string NameIdClaimType { get; set;}
        public string CallbackPath { get; set;}
        public string SignInScheme { get; set;}

    }
}