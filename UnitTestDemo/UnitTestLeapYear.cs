namespace UnitTestDemo
{
    public class Tests
    {
        private LeapYearCheckerTest _leapYearCheckerTest;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void This_year_is_not_a_leap_year()
        {
            _leapYearCheckerTest = new LeapYearCheckerTest(2023);
            Assert.That(_leapYearCheckerTest.IsLeapYear(), Is.EqualTo("2023 is not a leap year"));
        }
        [Test]
        public void This_year_is_a_leap_year()
        {
            _leapYearCheckerTest = new LeapYearCheckerTest(2020);
            Assert.That(_leapYearCheckerTest.IsLeapYear(), Is.EqualTo("2020 is a leap year"));
        }
    }
    class LeapYearCheckerTest : LeapYearChecker
    {
        private readonly int _year;
        public LeapYearCheckerTest(int year)
        {
            _year = year;
        }
        protected override int GetYear()
        {
            return _year;
        }
    }
}