using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core
{
    public class LocalWebDriver
    {
        public static IWebDriver IniciarDriver()
        {
            string url = "https://www.saucedemo.com/";
            string rutaDeDrivers = ObtenerRutaDriver();

            IWebDriver driver = new ChromeDriver(rutaDeDrivers);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            return driver;

        }

        private static string ObtenerRutaDriver()
        {
            string rutaDirectorio = Directory.GetCurrentDirectory();
            return rutaDirectorio + "\\LocalDriver";
        }
    }
}
