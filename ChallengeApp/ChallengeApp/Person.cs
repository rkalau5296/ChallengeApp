namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }

        public Person(string name, string surname, char gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;            
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;            
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person()
        {
            
        }
    }
}
