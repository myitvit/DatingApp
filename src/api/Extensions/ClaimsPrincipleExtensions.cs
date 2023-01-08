using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            // Get the username from the request token
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}