using OpenQA.Selenium;
using NUnitAutomationFramework.WebElements;
using NUnitAutomationFramework.Base;
using AventStack.ExtentReports;
using NUnitAutomationFramework.Utility;
using NUnit.Framework;

namespace NUnitAutomationFramework.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly ExtentTest test;
        public HomePage(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

        #region "PageObjects"

        readonly string LoginPage_Header = "//p[text()='Please enter your credentials to sign in!']";
        readonly string WrongCreds = "//div[text()='The username or password is incorrect.']";
        readonly string Organization = "//input[@name='organisation']";
        readonly string Organization_Req = "//input[@name='organisation']/following-sibling::div";
        readonly string UserName = "//input[@name='userName']";
        readonly string UserName_Req = "//input[@name='userName']/following-sibling::div";
        readonly string PassWord = "//input[@name='password']";
        readonly string PassWord_Req = "//input[@name='password']/parent::span/following-sibling::div";
        readonly string PassWord_8L = "//input[@name='password']/parent::span/following-sibling::div";
        readonly string SignIn = "//button[text()='Sign In']";
        readonly string Avtar_UserName = "//span[@class='avatar avatar-circle']/following-sibling::div/div";

        readonly string RememberMe = "//input[@name='rememberMe']";

        readonly string ForgotPassword = "//a[text()='Forgot Password?']";
        readonly string ForgotPassword_Header = "//h3[text()='Forgot Password']";

        readonly string SignUp = "//a[text()='Sign up']";
        readonly string SignUp_Header = "//h3[text()='Create your account']";

        #endregion

        public void NavigateToURL()
        {
            string? url = GetEnvironementData.GetEnvData();
            ActionsElements.NavigateToUrl(driver, url);
            test.Log(Status.Pass, "Navigated To: " + url);
            Thread.Sleep(5000);
        }

        public void EnterCredentials()
        {
            string? TcName = TestContext.CurrentContext.Test.MethodName;
            string OrgName = ReadTestData.GetTestData(TcName, "OrgName");
            string Username = ReadTestData.GetTestData(TcName, "UserName");
            string Password = ReadTestData.GetTestData(TcName, "Password");

            ActionsElements.SendKeys(driver, By.XPath(Organization), OrgName);
            test.Log(Status.Pass, "Entered 'Organization Name': " + OrgName);
            ActionsElements.SendKeys(driver, By.XPath(UserName), Username);
            test.Log(Status.Pass, "Entered 'UserName': " + Username);
            ActionsElements.SendKeys(driver, By.XPath(PassWord), Password);
            test.Log(Status.Pass, "Entered 'Password': " + Password);
            ActionsElements.Click(driver, By.XPath(SignIn), 5);
            test.Log(Status.Pass, "Clicked Button/Link 'Sign In' Successfully");
            Thread.Sleep(2500);
        }

        public void ValidateForgetPassword()
        {
            ActionsElements.Click(driver, By.XPath(ForgotPassword), 5);
            test.Log(Status.Pass, "Clicked Button/Link 'Forgot Password' Successfully");
            Thread.Sleep(2500);

            IWebElement FP_Header = driver.FindElement(By.XPath(ForgotPassword_Header));
            Assert.True(FP_Header.Displayed);
            test.Log(Status.Pass, "'Forget Password' Page Displayed Successfully.");
        }

        public void ValidateSignUp()
        {
            ActionsElements.Click(driver, By.XPath(SignUp), 5);
            test.Log(Status.Pass, "Clicked Button/Link 'Sign Up' Successfully");
            Thread.Sleep(2500);

            IWebElement SU_Header = driver.FindElement(By.XPath(SignUp_Header));
            Assert.True(SU_Header.Displayed);
            test.Log(Status.Pass, "'Sign Up' Page Displayed Successfully.");
        }

        public void ValidateRequiredField_Organization()
        {
            IWebElement OrgReq = driver.FindElement(By.XPath(Organization_Req));
            Assert.True(OrgReq.Displayed);
            test.Log(Status.Pass, "Required Info Error: '" + OrgReq.Text + "', Displayed Successfully.");
        }

        public void ValidateRequiredField_UserName()
        {
            IWebElement UN_Req = driver.FindElement(By.XPath(UserName_Req));
            Assert.True(UN_Req.Displayed);
            test.Log(Status.Pass, "Required Info Error: '" + UN_Req.Text + "', Displayed Successfully.");
        }

        public void ValidateRequiredField_PassWord()
        {
            IWebElement PW_Req = driver.FindElement(By.XPath(PassWord_Req));
            Assert.True(PW_Req.Displayed);
            test.Log(Status.Pass, "Required Info Error: '" + PW_Req.Text + "', Displayed Successfully.");
        }

        public void ValidateField_PassWord_8Length()
        {
            IWebElement PW_Req = driver.FindElement(By.XPath(PassWord_8L));
            Assert.True(PW_Req.Displayed);
            test.Log(Status.Pass, "Pasword Length Validation Failed & Error: '" + PW_Req.Text + "', Displayed Successfully.");
        }

        public void ValidateInvalidCredentialPopup()
        {
            IWebElement W_UnPw = driver.FindElement(By.XPath(WrongCreds));
            Assert.True(W_UnPw.Displayed);
            test.Log(Status.Pass, "Error: '" + W_UnPw.Text + "', Displayed Successfully.");
        }

        public void ValidateUserNotLoggedIn()
        {
            IWebElement Header = driver.FindElement(By.XPath(LoginPage_Header));
            Assert.True(Header.Displayed);
            test.Log(Status.Pass, "User Not Logged In As Expected.");
        }

        public void ValidateUserName()
        {
            string? TcName = TestContext.CurrentContext.Test.MethodName;
            string ExpUsername = ReadTestData.GetTestData(TcName, "UserName");
            string ActUserName = driver.FindElement(By.XPath(Avtar_UserName)).Text;
            Assert.That(ActUserName, Is.EqualTo(ExpUsername));
            test.Log(Status.Pass, "Logged In As Expected User With 'UserName': " + ActUserName + " Successfully");
            Thread.Sleep(2500);
        }
    }
}

