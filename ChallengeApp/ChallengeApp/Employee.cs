﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string lastname, int age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int Age { get; private set; }
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
        public void RemoveScore(int number)
        {
            this.score.Remove(number);
        }
    }
}