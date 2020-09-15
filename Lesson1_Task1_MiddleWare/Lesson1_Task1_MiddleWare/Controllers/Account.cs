using System;

using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    public class Account : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public Account(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var loginResult = await _signInManager.PasswordSignInAsync(
                model.UserName,
                model.Password,
                model.RememberMe, /*Возвращает значение, указывающее, имеется ли файл Cookie, содержащий сведения о билете проверки подлинности форм*/
                lockoutOnFailure: false //Флаг, указывающий, следует ли заблокировать учетную запись пользователя в случае сбоя входа.
                );    
            
            if(!loginResult.Succeeded)
            {
                ModelState.AddModelError("", "Вход не возможен!");
                return View(model);
            }

            if (Url.IsLocalUrl(model.UrlReturn))
                return Redirect(model.UrlReturn);

            return Redirect("/Store/Index");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Store");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = new User() { UserName = model.UserName, Email = model.EmailAdress };

            var newUser = await _userManager.CreateAsync(user, model.Password);

            if (newUser.Succeeded)
            {
                await _signInManager.SignInAsync(user, false); //Флаг, указывающий, должен ли файл cookie для входа сохраняться после закрытия браузера.
                return Redirect("/Store/Index");
            }

            foreach (var identityError in newUser.Errors) //выводим ошибки при их наличии
            {
                ModelState.AddModelError("", identityError.Description);
            }
            return View(model);
        }


    }
}
