using Microsoft.AspNetCore.Identity;
using Movie_app_api.Models;

namespace Movie_app_api.Interfaces
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
    }
}
