using OpenQA.Selenium;
using Core;

namespace Page
{
    public class LoginPage : PageBase
    {
        #region Propiedades
        By usernameFld = By.Id("user-name");
        By passwordFld = By.Id("password");
        By loginBtn = By.Id("login-button");

        #endregion

        #region Métodos
        public LoginPage(IWebDriver driver)
            : base(driver)
        {

        }

        public void CompletarCampoUsername(string username)
        {
            EnviarTexto(usernameFld, username);
        }

        public void CompletarCampoPassword(string pass)
        {
            EnviarTexto(passwordFld, pass);
        }

        public void PresionarBotonLogin()
        {
            Click(loginBtn);
        }

        #endregion
    }
}