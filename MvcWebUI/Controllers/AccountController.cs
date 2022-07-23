using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcWebUI.Entities;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class AccountController:Controller
    {
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

         public ActionResult Register()
         {
            return View();
         }

         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Register(RegisterViewModel registerViewModel)
         {
             var roleName = "User";
            if(ModelState.IsValid)
            {
                 CustomIdentityUser user = new CustomIdentityUser
                 {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email
                 };
                 IdentityResult result = 
                  _userManager.CreateAsync(user, registerViewModel.Password).Result;
                  if(result.Succeeded)
                  {
                       if(!_roleManager.RoleExistsAsync(roleName).Result)
                       {
                           CustomIdentityRole role = new CustomIdentityRole
                           {
                              Name = roleName
                           };
                           IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
                           if(!roleResult.Succeeded)
                           {
                               ModelState.AddModelError("", "We can't add the role!");
                               return View(registerViewModel);
                           }
                       }
                        _userManager.AddToRoleAsync(user, roleName).Wait();
                        return RedirectToAction("Login", "Account");
                  }
            }
                return View(registerViewModel);
         }
          public ActionResult Login()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
         
            if (ModelState.IsValid)
            {
                
                var result = 
                _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false).Result;

                if(result.Succeeded)
                {
                     var user =  _userManager.FindByNameAsync(loginViewModel.UserName).Result;
                     var roles =  _userManager.GetRolesAsync(user);
                    var role =  roles.Result.Contains("Admin");
                    return RedirectToAction("Index", "Product");
                }
                ModelState.AddModelError("", "Invalid Login!");
            }
            return View(loginViewModel);
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }

        
    }
}