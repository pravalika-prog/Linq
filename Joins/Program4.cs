using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace linq
{
  public  class Program4
    {
        static void Main()
        {
            var JoinUsingMS = Employee1.GetAllEmployees() 
                           .Join(
                           Address.GetAllAddresses(),  
                           employee => employee.AddressId, 
                           address => address.ID, 
                           (employee, address) => new 
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            Console.ReadLine();
        }
    }
}
       
