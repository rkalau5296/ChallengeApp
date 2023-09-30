namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {            
        }
        
        public override void AddGrade(float grade)
        {
              if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
                if(GradeAdded != null)
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
            if (float.TryParse(grade, out float result))
            {
                AddGrade(float.Parse(grade));
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(char grade)
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

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }      
}
