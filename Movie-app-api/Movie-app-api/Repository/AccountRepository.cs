using Microsoft.AspNetCore.Identity;
using Movie_app_api.Interfaces;
using Movie_app_api.Models;

namespace Movie_app_api.Repository
{
    public class AccountRepository: IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                Email = signUpModel.Email,
                UserName = signUpModel.Email
            };
            return await _userManager.CreateAsync(user, signUpModel.Password);
        }
    }
}
