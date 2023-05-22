namespace GoCloudNative.Bff.Authentication.Auth0;

public class Auth0Config
{
    public string ClientId { get; set; } = string.Empty;
    
    public string ClientSecret { get; set; } = string.Empty;
    
    public string Domain { get; set; } = string.Empty;
    
    public string Audience { get; set; } = string.Empty;

    public string[] Scopes { get; set; } = Array.Empty<string>();

    public bool FederatedLogout { get; set; } = false;
}