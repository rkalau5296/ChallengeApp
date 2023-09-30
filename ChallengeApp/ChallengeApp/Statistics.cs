namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                return Average switch
                {
                    var average when average >= 90 => 'A',
                    var average when average >= 60 => 'B',
                    var average when average >= 40 => 'C',
                    var average when average >= 20 => 'D',
                    _ => 'E',
                };
            }
        }
        public float Sum { get; set; }
        public float Count { get; set; }
        public Statistics()
        {
            Count = 0;
            Sum = 0;
            Max = float.MinValue;
            Min = float.MaxValue;
        }
        public void AddGrade(float grade)
        {
            Count++;
            Sum += grade;
            Min = Math.Min(Min, grade);
            Max = Math.Max(Max, grade);            
        }
    }
}
