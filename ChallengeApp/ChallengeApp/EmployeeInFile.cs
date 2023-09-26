namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grade.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using var writer = File.AppendText(fileName);
            writer.WriteLine(grade);
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

            Statistics statistics = new()
            {
                Average = 0,
                Max = float.MaxValue,
                Min = float.MinValue,
            };           

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= grades.Count;
            statistics.AverageLetter = statistics.Average switch
            {
                var a when a >= 90 => 'A',
                var a when a >= 60 => 'B',
                var a when a >= 40 => 'C',
                var a when a >= 20 => 'D',
                _ => 'E',
            };
            return statistics;
        }
    }
}
