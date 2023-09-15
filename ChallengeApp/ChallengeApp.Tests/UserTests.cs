namespace ChallengeApp.Tests
{
    public class UserTests
    {        
        [Test]
        public void WhenUserCollectTwoScpres_ShouldCorrectResult()
        {
            // arrange
            var user = new User("Rafal", "asdasdas324");
            user.AddScore(5);
            user.AddScore(-3);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(2, result);
        }
    }
}