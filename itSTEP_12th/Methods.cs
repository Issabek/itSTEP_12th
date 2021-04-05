using System;
using System.Collections.Generic;
using STEP.Employee;
using STEP.Student;
using System.Linq;
namespace itSTEP_12th
{
    public static class Methods
    {
        #region 1task
        public static void GetByPosition(this List<IEmployee> ts, Position position)
        {
            foreach (var item in ts)
            {
                string res = item.ePosition == position ? item.ToString() : null;
                if (res is null)
                    continue;
                Console.WriteLine(res);
            }
        }
        public static void GetMeanManager(this List<IEmployee> ts)
        {
            double MeanSal = ts.Where(t => t.ePosition == Position.Clerk).Average(s => s.Salary);
            List<IEmployee> managers = ts.Where(m => m.Salary >= MeanSal).OrderBy(o => o.LastName).ToList();
            foreach(Employee employee in managers)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        public static void GetByHireDate(this List<IEmployee> ts,DateTime date)
        {
            foreach (Employee employee in ts.Where(e=>e.HireDate>date).OrderBy(l=>l.LastName))
            {
                Console.WriteLine(employee.ToString());
            }
        }
        public static void GetEmployees(this List<IEmployee> ts, int Gender=2)
        {
            if(Gender>1)
                foreach (Employee employee in ts)
                {
                    Console.WriteLine(employee.ToString());
                }
            else if (Gender == 1)
                foreach (Employee employee in ts.Where(t=>t.Gender==true))
                {
                    Console.WriteLine(employee.ToString());
                }
            else if (Gender == 0)
                foreach (Employee employee in ts.Where(t => t.Gender == false))
                {
                    Console.WriteLine(employee.ToString());
                }
        }
        #endregion
        #region 2task
        public static void PopulateDorm(this List<Student> sts)
        {
            int counter = 1;
            foreach (Student st in sts.OrderBy(s => s.AverageIncome < 85000).ThenByDescending(s => s.GPA)){
                if (counter <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(counter<=20 && counter > 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(st.ToString());
            }
        }
        public static void GetNotFullFamily(this List<Student> sts)
        {
            foreach (Student st in sts.Where(s=>s.isFullFamily==false))
            {
                Console.WriteLine(st.ToString());
            }
        }
        public static void TopTenScore(this List<Student> sts)
        {
            foreach (Student st in sts.OrderBy(s=>s.GPA))
            {
                Console.WriteLine(st.ToString());
            }
        }
        public static void BottomTenScore(this List<Student> sts)
        {
            foreach (Student st in sts.OrderByDescending(s => s.GPA))
            {
                Console.WriteLine(st.ToString());
            }
        }
        public static void ThreeStuds(this List<Student> sts)
        {
            int counter = 1; 
            foreach (Student st in sts.OrderBy(s => s.isFullFamily==false).ThenBy(s => s.AverageIncome))
            {
                if (counter > 3)
                    break;
                Console.WriteLine(st.ToString());
                counter++;
            }
        }
        #endregion
    }
}
