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
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                AddGrade(float.Parse(grade));
            }
            else
            {
                Console.WriteLine("String is not float");
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

        public Statistics GetStatisticsWithForEach()
        {
            Statistics statistics = new()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };
            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            Statistics statistics = new()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };
            for (int i=0; i<grades.Count; i++)
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
            Statistics statistics = new()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };
            int i = 0; 
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
                i++;
            } while (i<grades.Count);

            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            Statistics statistics = new()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };
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