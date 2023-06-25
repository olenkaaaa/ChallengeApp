namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenUserGetGrades_CheckIfMaxValueIsCorrect()
        {
            var emp1 = new Employee("Dorota", "Kowalska");
            emp1.AddGrade(3);
            emp1.AddGrade(4);
            emp1.AddGrade(5);

            var statistics = emp1.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]

        public void WhenUserGetGrades_CheckIfMinValueIsCorrect()
        {
            var emp2 = new Employee("Jan", "Musiał");
            emp2.AddGrade(10);
            emp2.AddGrade(2);
            emp2.AddGrade(6);

            var statistics = emp2.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void WhenUserGetGrades_CheckIfAverageValueIsCorrect()
        {
            var emp3 = new Employee("Tomasz", "Zięba");
            emp3.AddGrade(3);
            emp3.AddGrade(7);
            emp3.AddGrade(1);
            emp3.AddGrade(9);

            var statistics = emp3.GetStatistics();

            Assert.AreEqual(5, statistics.Average);
        }
    }
}
