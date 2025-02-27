
using System.Security.Claims;

namespace BibCorp.API.Extensions.Users
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserNameClaim(this ClaimsPrincipal user) {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static int GetUserIdClaim(this ClaimsPrincipal user) {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }

    }
}
