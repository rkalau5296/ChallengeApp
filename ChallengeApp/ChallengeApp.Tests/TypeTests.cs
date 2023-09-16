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
        public void WhenEmployeesNameIsTheSame()
        {
            // arrange
            var employee1 = GetEmployee("Adam", "Zawadzki");
            var employee2 = GetEmployee("Adam", "Zawadzki");

            // act


            // assert
            Assert.That(employee1, Is.Not.EqualTo(employee2));
        }        
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
