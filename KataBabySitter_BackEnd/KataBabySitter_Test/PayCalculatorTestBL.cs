using NUnit.Framework;
using KataBabySitter_BLL;
using KataBabySitter_BOL;

namespace KataBabySitter_Test
{
    public class PayCalculatorTestBL
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetEmployeePay()
        {
            var payCalculator = new PayCalculator();
            var workTime = new WorkTime()
            {
                StartTime = 1,
                EndTime = 12
            };
            double expected = 136.00;

            double result = payCalculator.GetEmployeePay(workTime);
            Assert.IsTrue(result == expected);
        }
    }
}