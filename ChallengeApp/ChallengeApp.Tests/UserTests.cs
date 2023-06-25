namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange 
            var user = new User("Adam", "asusb327sb");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
    }
}