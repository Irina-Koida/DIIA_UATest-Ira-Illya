using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class OsvitaPage
    {
        private readonly IWebDriver _webDriver;
        public OsvitaPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickLanguageSwichButton = By.CssSelector("[class=\"lang - switcher__button\"]");
        private readonly By _clickLanguageSwichDropduwn = By.CssSelector("[class=\"lang-switcher__dropdown \"]");
        private readonly By _headerTitle = By.CssSelector("[class=\"president - appeal__title h1\"]");
        private readonly By _StartTeslingButton = By.CssSelector("[div.president-appeal__col.president-appeal__content > a]");
        private readonly By _LoginToStartButton = By.CssSelector("[div.digigram-start-heading__col.digigram-start-heading__content > div > a]");
        private readonly By _GoFacebookLoginButton = By.CssSelector("[a.social-button.login-form-block__fb-button]");
        private readonly By _FacebookFieldLogin = By.Id("[id=\"email\"]");
        private readonly By _FacebookFieldPassword = By.Id("[id=\"pass\"]");
        private readonly By _FacebookLoginButton = By.Id("[id=\"loginbutton\"]");
        private readonly By _MyPageHeaderTitle = By.CssSelector("[class=\"account-heading__title h1\"]");
        private readonly By _HeaderDigigramButton = By.CssSelector("[nav>ul>li:nth-child(3)>a]");
        private readonly By _StartTestButtonAfterLogin = By.CssSelector("[div.digigram-start-heading__col.digigram-start-heading__content > div > button");
        private readonly By _KindTestFromListForCityzen = By.CssSelector("[div.modal-digigram-list__content>div>div:nth-child(3)]");

        private readonly By _NameInputField = By.Name("[name=\"first_name\"]");
        private readonly By _LastNameInpuyField = By.Name("[name=\"last_name\"]");
        private readonly By _GenderField = By.CssSelector("[div:nth-child(4)>div>div.dropdown__head>span]");
        private readonly By _GenderDropdown = By.CssSelector("[div.dropdown__body.dropdown__body--placeholder > div:nth-child(1)]");
        private readonly By _AgeSelectField = By.CssSelector("[div:nth-child(5)>div>div.dropdown__head>span]");
        private readonly By _AgeSelectCategory = By.CssSelector("[div:nth-child(5)>div>div.dropdown__body.dropdown__body--placeholder > div:nth-child(2)]");
        private readonly By _RegionOrerField = By.CssSelector("[div:nth-child(6)>div>div.dropdown__head>span]");
        private readonly By _RegionOrderDropdown = By.CssSelector("[form>div:nth-child(6)>div>div.dropdown__body.dropdown__body--placeholder > div:nth-child(2)]");
        private readonly By _CareerOrded = By.CssSelector("[div:nth-child(9) > div > div.dropdown__head > span]");
        private readonly By _CareerOrderDropdown = By.CssSelector("[div:nth-child(9)>div>div.dropdown__body.dropdown__body--placeholder>div:nth-child(1)]");
        private readonly By _RadioButtonTestPurpose = By.CssSelector("[class=\"simple-radio__label p\"]");
        private readonly By _CompanyNameField = By.Name("[name=\"company_name\"]");

        private readonly By _ReasonToTestField = By.CssSelector("[div:nth-child(12) > div > div.dropdown__head > span]");
        private readonly By _ReasonToTesdDropdown = By.CssSelector("[div:nth-child(12) > div > div.dropdown__body.dropdown__body--placeholder>div:nth-child(1)]");
        private readonly By _FinalyGoToStartTest = By.CssSelector("[class=\"link link_styled link_type_colors\"]");

        private readonly By _DigigramHeader = By.CssSelector("[class=\"digiigram-test-title__title\"]");



        string LoginFacebook = "+380637179900";
        string PasswordFacebook = "aq1sw2de?";




        public OsvitaPage GoToOsvitaPage()
        {
            _webDriver.Navigate().GoToUrl("https://osvita.diia.gov.ua/");
            return this;
        }

        public OsvitaPage SwichLanguage()
        {
            _webDriver.FindElement(_clickLanguageSwichButton).Click();
            _webDriver.FindElement(_clickLanguageSwichDropduwn).Click();
            return this;
        }
        public OsvitaPage CheckLanguageChanged()
        {
            _webDriver.Url.ToString().Equals("https://osvita.diia.gov.ua/en");
            return this;

        }

        public OsvitaPage LoginToOsvitaPlatform()
        {
            _webDriver.FindElement(_StartTeslingButton).Click();
            _webDriver.FindElement(_GoFacebookLoginButton).Click();
            _webDriver.FindElement(_FacebookFieldLogin).SendKeys(LoginFacebook);
            _webDriver.FindElement(_FacebookFieldPassword).SendKeys(PasswordFacebook);
            _webDriver.FindElement(_FacebookLoginButton).Click();
            _webDriver.FindElement(_HeaderDigigramButton).Click();
            _webDriver.FindElement(_StartTestButtonAfterLogin).Click();
            _webDriver.FindElement(_KindTestFromListForCityzen).Click();
            return this;
        }

        public OsvitaPage InfoAboutForm()
        {
            _webDriver.FindElement(_NameInputField).SendKeys("Name");
            _webDriver.FindElement(_LastNameInpuyField).SendKeys("LastName");
            _webDriver.FindElement(_GenderField).Click();
            _webDriver.FindElement(_GenderDropdown).Click();
            _webDriver.FindElement(_AgeSelectField).Click();
            _webDriver.FindElement(_AgeSelectCategory).Click();
            _webDriver.FindElement(_RegionOrerField).Click();
            _webDriver.FindElement(_RegionOrderDropdown).Click();
            _webDriver.FindElement(_CareerOrded).Click();
            _webDriver.FindElement(_CareerOrderDropdown).Click();
            _webDriver.FindElement(_RadioButtonTestPurpose).Click();
            _webDriver.FindElement(_CompanyNameField).SendKeys("SomeWork");
            _webDriver.FindElement(_ReasonToTestField).Click();
            _webDriver.FindElement(_ReasonToTesdDropdown).Click();
            _webDriver.FindElement(_FinalyGoToStartTest).Click();
            return this;


        }
        public OsvitaPage TextTitlePageDigigramAssert()
        {
            _webDriver.FindElement(_DigigramHeader).Text.Contains("Цифрограм");
            return this;
        }
    }
}