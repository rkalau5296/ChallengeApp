namespace ChallengeApp.Tests
{
    public class UserTests
    {        
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult_SumVersion()
        {
            // arrange
            var user = new User("Rafal", "asdasdas324");
            user.AddScore(5);
            user.AddScore(-3);

            // act
            var result = user.Sum;

            // assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectResult()
        {
            // arrange
            var user = new User("Rafal", "asdasdas324");
            user.AddScore(5);
            user.AddScore(3);
            user.RemoveScore(3);

            // act
            var result = user.Sum;

            // assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}