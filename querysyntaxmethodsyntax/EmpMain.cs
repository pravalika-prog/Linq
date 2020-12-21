static void Main()
        {

            IEnumerable<Employee> methodsyntax = Employee.getemployee();
            IEnumerable<Employee> querysytax = from emp in Employee.getemployee() select emp;

            foreach (Employee emp in methodsyntax)
            {
                Console.WriteLine("id:{emp.id},fistname:{emp.firstname},lastname:{emp.lastname}");

            }
        }
    }
}
