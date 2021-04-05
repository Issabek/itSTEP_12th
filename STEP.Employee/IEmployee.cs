using System;
namespace STEP.Employee
{
    public enum Position
    {
        Clerk,
        Manager
    }
    public interface IEmployee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public bool Gender { get; set; }
        public Position ePosition { get; set; }
    }
}
