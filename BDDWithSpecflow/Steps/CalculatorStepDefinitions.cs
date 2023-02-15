using System.Diagnostics;
using TechTalk.SpecFlow;

namespace BDDWithSpecflow.Steps
{
    [Binding]
    public class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

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
            Debug.WriteLine("Second Number:" + fnumber);
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

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            
        }
    }
}
