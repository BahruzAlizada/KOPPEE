using KOPPEE.Helper;
using KOPPEE.Models;
using KOPPEE.ViewsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KOPPEE.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager=roleManager;
        }

        public async Task<IActionResult> Index()
        {
            List<AppUser> dbusers = await  _userManager.Users.ToListAsync();

            List<UserVM> usersVM = new List<UserVM>();
            foreach (AppUser dbUser in dbusers)
            {
                UserVM userrr = new UserVM
                {
                    Id = dbUser.Id,
                    Name = dbUser.Name,
                    Surname = dbUser.Surname,
                    UserName = dbUser.UserName,
                    Email = dbUser.Email,
                    IsDeactive = dbUser.IsDeactive,
                    Role=(await _userManager.GetRolesAsync(dbUser))[0]
                };
                usersVM.Add(userrr);
            }
            return View(usersVM);
        }

        #region Create
        public async Task<IActionResult> Create()
        {

            ViewBag.Roles = new List<string>
            {
                Helper.Roles.Admin.ToString(),
                Helper.Roles.Member.ToString()
            };

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CreateVM createVM, string role)
        {
            ViewBag.Roles = new List<string>
            {
                Helper.Roles.Admin.ToString(),
                Helper.Roles.Member.ToString()
            };

            AppUser newuser = new AppUser
            {
                Name = createVM.Name,
                Surname = createVM.Surname,
                UserName = createVM.UserName,
                Email = createVM.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newuser, createVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            await _userManager.AddToRoleAsync(newuser, role);


            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(string id)
        {
            if (id == null)
                return NotFound();
            AppUser dbuser = await _userManager.FindByIdAsync(id);
            if (dbuser == null)
                return BadRequest();

            UpdateVM dbupdateVM = new UpdateVM
            {
                Name = dbuser.Name,
                Surname = dbuser.Surname,
                UserName = dbuser.UserName,
                Email = dbuser.Email,
                Role=(await _userManager.GetRolesAsync(dbuser))[0]
            };

            ViewBag.Roles = new List<string>
            {
                Helper.Roles.Admin.ToString(),
                Helper.Roles.Member.ToString()
            };

            return View(dbupdateVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(string id, UpdateVM updateVM,string role)
        {
            if (id == null)
                return NotFound();
            AppUser dbuser = await _userManager.FindByIdAsync(id);
            if (dbuser == null)
                return BadRequest();

            UpdateVM dbupdateVM = new UpdateVM
            {
                Name = dbuser.Name,
                Surname = dbuser.Surname,
                UserName = dbuser.UserName,
                Email = dbuser.Email,
                Role = (await _userManager.GetRolesAsync(dbuser))[0]
            };

            ViewBag.Roles = new List<string>
            {
                Helper.Roles.Admin.ToString(),
                Helper.Roles.Member.ToString()
            };

            dbuser.Name = updateVM.Name;
            dbuser.Surname = updateVM.Surname;
            dbuser.UserName = updateVM.UserName;
            dbuser.Email = updateVM.Email;

            if(dbupdateVM.Role != role)
            {
              IdentityResult identityResultremove =  await _userManager.RemoveFromRoleAsync(dbuser, dbupdateVM.Role);
               if(!identityResultremove.Succeeded)
                {
                    foreach(IdentityError error in identityResultremove.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
                IdentityResult identityResuladd = await _userManager.AddToRoleAsync(dbuser,role);
                if (!identityResultremove.Succeeded)
                {
                    foreach (IdentityError error in identityResultremove.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }

            }
            await _userManager.UpdateAsync(dbuser);
            return RedirectToAction("Index");
        }
        #endregion

        #region ResetPassword
        public async Task<IActionResult> ResetPassword(string id)
        {
            if (id == null)
                return NotFound();
            AppUser dbuser = await _userManager.FindByIdAsync(id);
            if (dbuser == null)
                return BadRequest();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> ResetPassword(string id,ResetPasswordVM reset)
        {
            if (id == null)
                return NotFound();
            AppUser dbuser = await _userManager.FindByIdAsync(id);
            if (dbuser == null)
                return BadRequest();

            string token = await _userManager.GeneratePasswordResetTokenAsync(dbuser);
            IdentityResult identityResult = await _userManager.ResetPasswordAsync(dbuser, token, reset.Password);

            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(string id)
        {
            if (id == null)
                return NotFound();
            AppUser dbuser = await _userManager.FindByIdAsync(id);
            if (dbuser == null)
                return BadRequest();

            if (dbuser.IsDeactive)
                dbuser.IsDeactive = false;
            else
                dbuser.IsDeactive = true;

            await _userManager.UpdateAsync(dbuser);
            return RedirectToAction("Index");


        }
        #endregion
    }
}
