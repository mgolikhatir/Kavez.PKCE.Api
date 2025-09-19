using Kavez.PKCE;
using Kavez.PKCE.Api.Models;
using Kavez.PKCE.Core;
using Microsoft.AspNetCore.Mvc;

namespace Kavez.PKCE.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PkceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPkce([FromQuery] string method = "S256")
        {
            var verifier = PKCEHelper.GenerateCodeVerifier();
            var challenge = PKCEHelper.GenerateCodeChallenge(verifier, method);
            return Ok(new { verifier, challenge, method });
        }

        [HttpPost("verify")]
        public IActionResult VerifyPkce([FromBody] PkceVerificationRequest request)
        {
            var expectedChallenge = PKCEHelper.GenerateCodeChallenge(request.Verifier, request.Method);
            var isValid = expectedChallenge == request.Challenge;
            return Ok(new { isValid });
        }

        [HttpPost("token/mock")]
        public IActionResult MockToken([FromBody] TokenRequest request)
        {
            // فقط برای آموزش، بدون اتصال به Authorization Server
            return Ok(new
            {
                access_token = Guid.NewGuid().ToString(),
                token_type = "Bearer",
                expires_in = 3600
            });
        }

        [HttpGet("sample")]
        public IActionResult SampleFlow()
        {
            var verifier = PKCEHelper.GenerateCodeVerifier();
            var challenge = PKCEHelper.GenerateCodeChallenge(verifier, "S256");
            return Ok(new
            {
                verifier,
                challenge,
                redirect_uri = "https://localhost:5001/callback",
                client_id = "demo-client",
                authorization_url = $"https://auth.example.com/authorize?response_type=code&client_id=demo-client&code_challenge={challenge}&code_challenge_method=S256&redirect_uri=https://localhost:5001/callback"
            });
        }

    }
}