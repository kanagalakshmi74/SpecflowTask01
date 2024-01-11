using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFeature.StepDefinitions
{
    [Binding]
    public class CalTableStepDefinitions
    {
        [Given(@"the numbers are")]
        public void GivenTheNumbersAre(Table table)
        {
            Console.WriteLine("Numbers are");
            var data = table.CreateSet<Calculation>();
            foreach(var i in data)
            {
                Console.WriteLine("Numbers : " + i.Numbers);
            }
        }

        [When(@"adds two numbers")]
        public void WhenAddsTwoNumbers()
        {
            Console.WriteLine("When adds 2 Numbers");
        }

        [Then(@"result of addition (.*)")]
        public void ThenResultOfAddition(int p0)
        {
            Console.WriteLine("Result of Addition : "+p0);
        }

        [Given(@"numbers with sign")]
        public void GivenNumbersWithSign(Table table)
        {
            Console.WriteLine("Multiple row");
            var data = table.CreateSet<Calculation1>();
            foreach (var i in data)
            {
                Console.WriteLine("Value : " + i.Numbers2 + " type : "+i.sign);
            }

            Console.WriteLine("Multiple row using nuget package specflow.assist.dynamic ");
            var data1 = table.CreateDynamicSet();
            foreach (var i1 in data1)
            {
                Console.WriteLine("Value : " + i1.Numbers2 + " type : " + i1.sign);
            }
        }

        [When(@"adds next two numbers")]
        public void WhenAddsNextTwoNumbers()
        {
            Console.WriteLine("When adds Multiple row using nuget package specflow.assist.dynamic ");
        }

        [Then(@"result of second addition (.*)")]
        public void ThenResultOfSecondAddition(int p0)
        {
            Console.WriteLine("Result of Addition : " + p0);
        }

        [Given(@"the number")]
        public void GivenTheNumber(Table table)
        {
            Console.WriteLine("single row");
            var data = table.CreateInstance<Calculation1>();
            Console.WriteLine("Value : " + data.Numbers2 + " type : " + data.sign);

            Console.WriteLine("single row using nuget package specflow.assist.dynamic ");
            dynamic data1 = table.CreateDynamicInstance();
            Console.WriteLine("Value : " + data1.Numbers2 + " type : " + data1.sign);

        }

        [Then(@"result should be ""([^""]*)""")]
        public void ThenResultShouldBe(string positive)
        {
            Console.WriteLine("Result of Addition : " + positive);
        }

        [Given(@"numbers are (.*) and (.*)")]
        public void GivenNumbersAreAnd(int p1, int p2)
        {
            Console.WriteLine("first number :{0}", p1);
            Console.WriteLine("second number :{0}", p2);
        }


    }

    internal class Calculation
    {
        public int Numbers { get; set; }
    }
    internal class Calculation1
    {
        public int Numbers2 { get; set; }
        public string sign { get; set; }
    }
}


