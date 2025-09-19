using Kavez.PKCE;
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
    }
}