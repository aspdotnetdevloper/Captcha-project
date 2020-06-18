using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp3;
using TestApp3.Controllers;
using TestApp3.CustomActionResult;

namespace TestApp3.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ShowCaptchaImage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            CaptchaImageResult result = controller.ShowCaptchaImage() as CaptchaImageResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
