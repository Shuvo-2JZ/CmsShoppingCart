using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CmsShoppingCart;
using CmsShoppingCart.Controllers;

namespace CmsShoppingCartTest
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Car()
        {
            //Arrange
            CartController controller = new CartController();

            //Act
            ViewResult result = controller.Car() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        
    }
}
