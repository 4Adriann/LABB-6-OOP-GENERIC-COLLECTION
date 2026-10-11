using System.IO.Pipes;

namespace LABB_6_OOP_GENERIC_COLLECTION
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("Ethan", "Male", 134, 50000);
            Employee e2 = new Employee("Jill", "Female", 332, 60000);
            Employee e3 = new Employee("Leon", "Male", 581, 55000);
            Employee e4 = new Employee("Ada", "Female", 162, 70000);
            Employee e5 = new Employee("Carlos", "Male", 249, 65000);

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(e1);
            employeeStack.Push(e2);
            employeeStack.Push(e3);
            employeeStack.Push(e4);
            employeeStack.Push(e5);

            foreach (Employee emp in employeeStack)
            {
                Console.WriteLine($"Name: {emp.Name}, Gender: {emp.Gender}, Id: {emp.Id}, Salary: {emp.Salary}");
                Console.WriteLine($"Antal kvar i stacken: {employeeStack.Count}");
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Retrieving Using Pop Method");

            while (employeeStack.Count > 0)
            {
                Employee emp = employeeStack.Pop();
                Console.WriteLine($"Name: {emp.Name}, Gender: {emp.Gender}, Id: {emp.Id}, Salary: {emp.Salary}");
                Console.WriteLine($"Antal kvar i stacken: {employeeStack.Count}");
            }


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Retrieving Using Peek Method");
            employeeStack.Push(e1);
            employeeStack.Push(e2);
            employeeStack.Push(e3);
            employeeStack.Push(e4);
            employeeStack.Push(e5);

            for (int i = 0; i < 2; i++)
            {
                Employee emp = employeeStack.Peek();
                Console.WriteLine($"Name: {emp.Name}, Gender: {emp.Gender}, Id: {emp.Id}, Salary: {emp.Salary}");
                Console.WriteLine($"Antal kvar i stacken: {employeeStack.Count}");
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Contains");

            if (employeeStack.Contains(e3))
            {
                Console.WriteLine($"Employee {e3.Name} is in the stack.");
            }
            else
            {
                Console.WriteLine($"Employee {e3.Name} is not in the stack.");
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Del 2 lista");

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(e1);
            employeeList.Add(e2);
            employeeList.Add(e3);
            employeeList.Add(e4);
            employeeList.Add(e5);

            if (employeeList.Contains(e2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            Employee firstMale = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine();
            Console.WriteLine($"id = {firstMale.Id}, gender = {firstMale.Gender}, name = {firstMale.Name}, salary = {firstMale.Salary}");

            List<Employee> maleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine();
            Console.WriteLine("Male Employees:");
            foreach (Employee emp in maleEmployees)
            {
                Console.WriteLine($"id = {emp.Id}, gender = {emp.Gender}, name = {emp.Name}, salary = {emp.Salary}");
            }

        }
    }
}
        