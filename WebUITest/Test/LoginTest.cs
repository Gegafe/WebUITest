using NUnit.Framework;
using OpenQA.Selenium;
using Core;
using Page;

namespace Test
{
    public class LoginTest
    {
        
        [Test]
        public void Login()
        {
            IWebDriver driver = LocalWebDriver.IniciarDriver();

            try
            {
                LoginPage page = new LoginPage(driver);
                page.CompletarCampoUsername("standard_user");
                page.CompletarCampoPassword("secret_sauce");
                page.PresionarBotonLogin();

                Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url, "Verificaci�n de la p�gina de inventario.");
            }
            catch (System.Exception)
            {
                Assert.Fail("Ocurri� un error al ejecutar la prueba.");
            }
            finally
            {
                driver.Quit();
            }

            
        }
    }
}