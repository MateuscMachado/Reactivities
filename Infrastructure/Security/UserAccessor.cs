using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _hhtpContextAccessor;
        public UserAccessor(IHttpContextAccessor hhtpContextAccessor)
        {
            _hhtpContextAccessor = hhtpContextAccessor;
        }

        public string GetUsername()
        {
            return _hhtpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }
    }
}