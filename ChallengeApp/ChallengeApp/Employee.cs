namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new();

        public Employee(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;            
        }

        public string Name { get; private set; }
        public string Lastname { get; private set; }        
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;
            return statistics;
        }
    }
}