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
            using var writer = File.AppendText(fileName);
            writer.WriteLine(grade);
        }

        public override void AddGrade(char grade)
        {
            using var writer = File.AppendText(fileName);
            writer.WriteLine(grade);
        }

        public override void AddGrade(double grade)
        {
            using var writer = File.AppendText(fileName);
            writer.WriteLine(grade);
        }

        public override void AddGrade(long grade)
        {
            using var writer = File.AppendText(fileName);
            writer.WriteLine(grade);
        }

        public override Statistics GetStatistics()
        {
            List<float> grades = new();
            if (File.Exists($"{fileName}"))
            {
                using StreamReader reader = File.OpenText($"{fileName}");
                string? line = reader.ReadLine();
                while (line != null)
                {
                    float number = float.Parse(line);
                    grades.Add(number);
                    line = reader.ReadLine();
                }
            }

            Statistics statistics = new();
            
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;            
        }
    }
}
