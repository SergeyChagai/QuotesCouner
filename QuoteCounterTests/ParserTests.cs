using NUnit.Framework;
using QuotesCounter;

namespace QuoteCounterTests
{
    public class Tests
    {
        [TestCase("1327865tbvvnsad  sahg jhsadg( wduqwhd(_)skjdf", false)]
        [TestCase("1327865tbvvnsad  sahg jhsadg( wduqwhd_)skjdf", true)]
        [TestCase("1327865tbvvnsad  sahg jhsadg wduqwhd_skjdf", true)]
        [TestCase("(((){}[]]]])(", false)]
        [TestCase("(){}[][][]()", true)]
        [TestCase("({[]})()[]", true)]
        public void CheckQuotesEqualityTest(string enter, bool expected)
        {
            var actual = Parser.CheckQuotesEquality(enter);

            Assert.AreEqual(expected, actual);
        }
    }
}