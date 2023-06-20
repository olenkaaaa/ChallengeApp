namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectsTwoScores_ShouldCorrectResult()
        {
            // arrange 
            var employee = new Employee("Anna", "Nowak", 32);
            employee.AddPoints(8);
            employee.AddPoints(-2);
            employee.AddPoints(6);
            employee.AddPoints(-7);
            employee.AddPoints(1);

            // act
            var result = employee.Points;

            // assert
            Assert.AreEqual(6, result);
        }
    }
}