using KOPPEE.Models;
using KOPPEE.ViewsModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KOPPEE.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,/*RoleManager<IdentityRole> roleManager,*/SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            //_roleManager = roleManager;
            _userManager= userManager;
        }

        #region Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            AppUser user = await _userManager.FindByEmailAsync(loginVM.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View();
            }

            if (user.IsDeactive)
            {
                ModelState.AddModelError("", "Your account is deactive");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.IsRemember, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View();
            }

            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Your account is blocked");
                return View();
            }

            return RedirectToAction("Index", "Home");

        }
            #endregion

        #region Register
            public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            AppUser newuser = new AppUser
            {
                Name = registerVM.Name,
                Surname=registerVM.Surname,
                UserName=registerVM.UserName,
                Email=registerVM.Email,   
                IsRemember=registerVM.IsRemember
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newuser, registerVM.Password);

            if(!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            await _userManager.AddToRoleAsync(newuser, Helper.Roles.Admin.ToString());
            await _signInManager.SignInAsync(newuser,registerVM.IsRemember);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region ForgotPassword
        public async Task<IActionResult> ForgotPassword(string id)
        {
            return View();
        }
        #endregion

        #region CreateRoles
        //public async Task Roles()
        //{
        //    if(!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helper.Roles.Admin.ToString() });
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Helper.Roles.Member.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helper.Roles.Member.ToString() });
        //    }
        //}
        #endregion
    }
}
