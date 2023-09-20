namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new();
        public Employee() : base("name")
        {

        }
        public Employee(string name) : base(name, "surname")
        {

        }


        public Employee(string name, string surname) : base(name, surname)
        {

        }

        public Employee(string name, string surname, char gender) : base(name, surname, gender)
        {

        }        

        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(float.Parse(grade));
            }
            else
            {
                throw new Exception("String is not float");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }
        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(short grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(ushort grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(uint grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        Statistics statistics = new()
        {
            Average = 0,
            Max = float.MinValue,
            Min = float.MaxValue
        };

        public Statistics GetStatistics()
        {
            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= grades.Count;
            switch (statistics.Average)
            {
                case var a when a >= 90:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
        

        public Statistics GetStatisticsWithFor()
        {
            for (int i = 0; i < grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            int i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
                i++;
            } while (i < grades.Count);
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            int i = 0;
            while (i < grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
                i++;
            }

            statistics.Average /= grades.Count;
            return statistics;
        }
    }
}