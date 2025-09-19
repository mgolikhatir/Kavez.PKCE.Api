namespace Kavez.PKCE.Api.Models
{
    public class PkceVerificationRequest
    {
        public string Verifier { get; set; } = string.Empty;
        public string Challenge { get; set; } = string.Empty;
        public string Method { get; set; } = "S256";
    }
}