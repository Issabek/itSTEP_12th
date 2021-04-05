using System;
using System.Collections.Generic;

namespace STEP.Employee
{
    public struct Employee:IEmployee
    {
        public string LastName { get  ; set  ; }
        public string FirstName { get  ; set  ; }
        public DateTime HireDate { get  ; set  ; }
        public int Salary { get  ; set  ; }
        public bool Gender { get  ; set  ; }
        public Position ePosition { get  ; set  ; }
        public override string ToString()
        {
            return string.Format("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", FirstName, LastName, Gender, HireDate, Salary, ePosition);
        }

    }
    
}
