using OpenQA.Selenium;

namespace Core
{
    public class PageBase
    {
        #region Propiedades
        protected IWebDriver driver;

        #endregion

        #region Métodos
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"></param>
        public PageBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Método para hacer click a un elemento web.
        /// </summary>
        /// <param name="locator"></param>
        protected void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }

        /// <summary>
        /// Método para enviar texto a un elemento web.
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="texto"></param>
        protected void EnviarTexto(By locator, string texto)
        {
            driver.FindElement(locator).SendKeys(texto);
        }

        #endregion
    }
}