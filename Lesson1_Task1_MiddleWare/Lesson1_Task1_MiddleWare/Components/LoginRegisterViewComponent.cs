using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Components
{
    [ViewComponent(Name = "LogReg")]
    public class LoginRegisterViewComponent : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
