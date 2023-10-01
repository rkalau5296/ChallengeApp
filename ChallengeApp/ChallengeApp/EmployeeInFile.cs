using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grade.txt";
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new();
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                using var writer = File.AppendText(fileName);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out _))
            {
                AddGrade(float.Parse(grade.ToString()));
            }
            else
            {
                throw new Exception("String is not float");
            }
        }
        public override void AddGrade(char grade)
        {            
            AddGrade((float)grade);
        }

        public override void AddGrade(double grade)
        {            
            AddGrade((float)grade);
        }
        public override void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }
        public override Statistics GetStatistics()
        {
            Statistics statistics = new();
            if (File.Exists($"{fileName}"))
            {
                using StreamReader reader = File.OpenText($"{fileName}");
                string? line = reader.ReadLine();
                while (line != null)
                {                    
                    statistics.AddGrade(float.Parse(line));
                    line = reader.ReadLine();
                }
            }           
            return statistics;            
        }        
    }
}
