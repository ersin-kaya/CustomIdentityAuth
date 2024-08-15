namespace DotNet8Authentication.Services.Settings;

public class TokenSettings
{
    public string Audience { get; set; }
    public string Issuer { get; set; }
    public string Key { get; set; }
    public int ExpirationMinutes { get; set; }
}