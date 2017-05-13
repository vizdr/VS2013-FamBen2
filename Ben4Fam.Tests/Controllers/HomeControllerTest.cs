using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ben4Fam;
using Ben4Fam.Controllers;

namespace Ben4Fam.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
