using System.Diagnostics;
using BDDWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace BDDWithSpecflow.Steps
{
    [Binding]
    public class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        Login login = new Login();
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        
        //******************************
        int fnumber;
        int snumber;
        int diff;
        [Given(@"user gave the first number")]
        public void GivenUserGaveTheFirstNumber()
        {
            fnumber = 22;
            Debug.WriteLine("First Number:" +fnumber);
        }

        [Given(@"user gave the second number")]
        public void GivenUserGaveTheSecondNumber()
        {
            snumber = 12;
            Debug.WriteLine("Second Number:" + snumber);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            diff = fnumber - snumber;
            Debug.WriteLine("Perform Subtraction");
        }

        [Then(@"validate the result")]
        public void ThenValidateTheResult()
        {
            Debug.WriteLine("Difference of two numbers :" + diff);
        }



        //***********************************
        int sum;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Debug.WriteLine("First Number :" + number);
            fnumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Debug.WriteLine("Second Number :" + number);
            snumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = fnumber + snumber;
            Debug.WriteLine("Sum of the two numbers :" + sum);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            if(sum == result)
            {
                Debug.WriteLine("Sum of the two numbers is correct :");
            }
            else
            {
                Debug.WriteLine("Sum of the two numbers is not correct :" );
            }
        }

        [Given(@"I Launched Application with '(.*)'")]
        public void GivenILaunchedApplicationWith(string URL)
        {
            //Debug.WriteLine("Launch the Application :" + URL);
            login.LaunchApplication(URL);
        }

        [When(@"I enter user credentials with '(.*)' '(.*)'")]
        public void WhenIEnterUserCredentialsWith(string UserName, string PassWord)
        {
            //Debug.WriteLine("Enter User Name  :" + UserName);
            //Debug.WriteLine("Enter PassWord  :" + PassWord);
            login.LoginToApplication(UserName, PassWord);
        }

        [Then(@"I should be logged in Successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            //Debug.WriteLine("User Login Successfull");
            login.ValidateUserLogin();
        }

        [Given(@"User Launched Application '(.*)'")]
        public void GivenUserLaunchedApplication(string p0)
        {
            login.LaunchApplication(p0);
        }

        [When(@"User Gave Login Details '(.*)' '(.*)'")]
        public void WhenUserGaveLoginDetails(string p0, string p1)
        {
            login.LoginToApplication(p0, p1);
        }

        [Then(@"User should be logged in Successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            login.ValidateUserLogin();
        }


    }
}
