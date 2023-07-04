namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            var employee = new Employee("Dorota", "Kowalska");
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            var employee = new Employee("Jan", "Musiał");
            employee.AddGrade(10);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Tomasz", "Zięba");
            employee.AddGrade(3);
            employee.AddGrade(7);
            employee.AddGrade(2);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(4.00, 2), Math.Round(statistics.Average, 2));
        }

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverageLetter()
        {
            var employee = new Employee();
            employee.AddGrade(50);
            employee.AddGrade('B');
            employee.AddGrade('a');
            employee.AddGrade(60);
            var statistics = employee.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}
