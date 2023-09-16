namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenNameIsTheSame()
        {
            // arrange
            string number1 = "Adam";
            string number2 = "Adam";

            // act


            // assert
            Assert.That(number1, Is.EqualTo(number2));
        }
        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            // act


            // assert
            Assert.That(user1, Is.Not.EqualTo(user2));
        }
        public void WhenEmployeesNameIsTheSame()
        {
            // arrange
            var employee1 = GetEmployee("Adam", "Zawadzki", 22);
            var employee2 = GetEmployee("Adam", "Zawadzki", 22);

            // act


            // assert
            Assert.That(employee1, Is.Not.EqualTo(employee2));
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
