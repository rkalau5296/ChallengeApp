namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public string name { get; private set; }
        public string lastname { get; private set; }
        public int age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
