using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp3.CustomActionResult;

namespace TestApp3.Controllers
{
    public class HomeController : Controller
    {

        public CaptchaImageResult ShowCaptchaImage()
        {
            return new CaptchaImageResult();
            //for failing test case => return null;
        }

        public ActionResult TestCaptcha()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TestCaptcha(string CaptchaText)
        {
            if (CaptchaText == HttpContext.Session["captchastring"].ToString())
                ViewBag.Message = "CAPTCHA verification successful!";
            else
                ViewBag.Message = "CAPTCHA verification failed!";

            return View();
        }
    }
}