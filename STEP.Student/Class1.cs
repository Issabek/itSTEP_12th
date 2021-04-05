using System;

namespace STEP.Student
{
    public enum sGender
    {
        Male,
        Female
    }
    public enum sStudyForm
    {
        Extramural,
        Internal
    }
    public struct Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Group { get; set; }
        public double GPA { get; set; }
        public int AverageIncome { get; set; }
        public bool isFullFamily { get; set; }
        public sGender Gender { get; set; }
        public sStudyForm StudyForm { get; set; }
        public override string ToString()
        {
            return string.Format("{0} -- {1} -- {2} -- {3} -- {4} -- {5} -- {6}", FirstName, LastName, GPA, AverageIncome);
        }
    }
}
