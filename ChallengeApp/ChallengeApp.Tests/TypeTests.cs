namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenYouCompareDifferentInts_ShouldNotBeEqual()
        {
            // arrange 
            int number1 = 5;
            int number2 = 8;
            // act 

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenYouCompareStrings_ShouldBeEqual()
        {
            // arrange 
            string name1 = "Adam";
            string name2 = "Adam"; // jest typem referencyjnym, ale zachowuje się jak typ wartościowy (tzw. niezmienne / immutable)

            // act 

            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void NewUsersSameLogins_ShouldBeEqual()
        {
            // arrange 
            var user1 = GetUser("Patryk");
            var user2 = GetUser("Patryk");

            // act 

            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange 
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act 

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name) // parametr 
        {
            return new User(name);
        }
    }
}
