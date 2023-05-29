namespace GoCloudNative.Bff.Authentication.OpenIdConnect;

public class OpenIdConnectConfig
{
    public string ClientId { get; set; } = string.Empty;
    
    public string ClientSecret { get; set; } = string.Empty;
    
    public string Authority { get; set; } = string.Empty;

    public string DiscoveryEndpoint { get; set; } = "/.well-known/openid-configuration";

    public string[] Scopes { get; set; } = Array.Empty<string>();

    public string PostLogoutRedirectEndpoint { get; set; } = "/";
}