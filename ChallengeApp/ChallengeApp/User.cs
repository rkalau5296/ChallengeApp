namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = login;            
        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        
        public int Sum
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
        public void RemoveScore(int number)
        {
            this.score.Remove(number);
        }
    }
}
