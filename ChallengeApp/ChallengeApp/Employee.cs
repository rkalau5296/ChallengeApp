﻿namespace ChallengeApp
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
            if (grade > 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }            
        }
        public void AddGrade(long grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(short grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(ushort grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(uint grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(int grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
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