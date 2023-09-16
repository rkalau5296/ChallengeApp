namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckIfAverageIsCorrect()
        {
            // arrange
            Employee employee = new("Jan", "Kowalski");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(statistics.Average, Is.EqualTo(4));
        }
        [Test]
        public void CheckIfMinIsCorrect()
        {
            // arrange
            Employee employee = new("Piotr", "Kwiatkowski");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(9);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(statistics.Average, Is.EqualTo(4.5f));
        }
        [Test]
        public void CheckIfMaxIsCorrect()
        {
            // arrange
            Employee employee = new("Andrzej", "Malinowski");
            employee.AddGrade(9);
            employee.AddGrade(3);
            employee.AddGrade(15);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(statistics.Average, Is.EqualTo(8.5f));
        }
    }
}
