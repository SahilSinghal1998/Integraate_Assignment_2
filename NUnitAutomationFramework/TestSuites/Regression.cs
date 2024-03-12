using NUnit.Framework;
using NUnitAutomationFramework.Base;
using NUnitAutomationFramework.Pages;
using NUnitAutomationFramework.Utility;

namespace NUnitAutomationFramework.TestSuites
{
    [Parallelizable(ParallelScope.Children)]
    public class Regression : BaseSetup
    {
        [Test, Category("Regression")]
        public void TC01_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateUserName();
        }

        [Test, Category("Regression")]
        public void TC02_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_Organization();
            page.ValidateRequiredField_UserName();
            page.ValidateRequiredField_PassWord();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC03_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC04_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateField_PassWord_8Length();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC05_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_PassWord();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC06_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_UserName();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC07_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_Organization();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC08_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC09_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC10_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC11_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_UserName();
            page.ValidateRequiredField_PassWord();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC12_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_Organization();
            page.ValidateRequiredField_PassWord();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC13_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateRequiredField_Organization();
            page.ValidateRequiredField_UserName();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC14_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC15_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC16_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.EnterCredentials();
            page.ValidateInvalidCredentialPopup();
            page.ValidateUserNotLoggedIn();
        }

        [Test, Category("Regression")]
        public void TC17_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.ValidateForgetPassword();
        }

        [Test, Category("Regression")]
        public void TC18_LoginScenario()
        {
            HomePage page = new(GetDriver(), extent_test.Value);
            page.NavigateToURL();
            page.ValidateSignUp();
        }
    }
}
