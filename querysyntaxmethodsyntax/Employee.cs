using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
  public  class Employee
    {
     public int id { get; set; }
        public string firstname { get; set;
        }
       public string lastname { get; set; } 
        public int salary { get; set; }
   
    
    public static List<Employee> getemployee()
    {
        List<Employee> employeelist = new List<Employee>()
{
new Employee{id=1,firstname="pranba"
,lastname="mango",salary=1000},
new Employee{id=2,firstname="pra"
,lastname="man",salary=2000},
new Employee{id=3,firstname="prav"
,lastname="mani",salary=3000},

};
        return employeelist;
    }
}
}





