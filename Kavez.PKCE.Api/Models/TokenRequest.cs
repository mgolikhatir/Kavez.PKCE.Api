namespace Kavez.PKCE.Api.Models
{
    public class TokenRequest
    {
        public string Code { get; set; } = string.Empty;
        public string RedirectUri { get; set; } = string.Empty;
        public string ClientId { get; set; } = string.Empty;
        public string CodeVerifier { get; set; } = string.Empty;
    }
}