using System;
using TechTalk.SpecFlow;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class UnknownSteps
    {
        [Given(@"You are on the Osvita page")]
        public void GivenYouAreOnTheOsvitaPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Login")]
        public void WhenILogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click to Цифрограм buttom from header menu")]
        public void WhenIClickToЦифрограмButtomFromHeaderMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click to Розпочати тестування button")]
        public void WhenIClickToРозпочатиТестуванняButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I choose a test to exam")]
        public void WhenIChooseATestToExam()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill about info form")]
        public void WhenIFillAboutInfoForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can start Digigram testing by clicking Перейти до тесту button")]
        public void ThenICanStartDigigramTestingByClickingПерейтиДоТестуButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}