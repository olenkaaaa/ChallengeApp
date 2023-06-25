namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenUserGetGrades_CheckIfStatisticsAreCorrect()
        {
            var emp1 = new Employee("Dorota", "Kowalska");
            emp1.AddGrade(3);
            emp1.AddGrade(4);
            emp1.AddGrade(5);

            var statistics = emp1.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(4.00, statistics.Average);
        }
    }
}
