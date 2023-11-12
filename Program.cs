using System.Net.WebSockets;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapat fem objekt med olika värden för egenskaper.
            Employee emp1 = new Employee(101, "Jana", "Female", 120000);
            Employee emp2 = new Employee(102, "Johan", "Male", 50000);
            Employee emp3 = new Employee(103, "Sara", "Female", 75000);
            Employee emp4 = new Employee(104, "Pia", "Female", 150000);
            Employee emp5 = new Employee(105, "Peter", "Male", 65000);

            //Skapat en stack och lagt till objekten med Push().
            Stack<Employee> empStack = new Stack<Employee>();
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            //Skriver ut objekten i stacken med en foreach-loop och visar antal objekt.
            Console.WriteLine("Objects in stack");
            foreach (Employee employee in empStack)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Objects left in stack = {empStack.Count}");
            }

            //Tar bort objekten från stacken med Pop(); metoden och visar antal objekt som är kvar.
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Retrive using Pop Method");

            while (empStack.Count > 0)
            {
                Employee poppedEmployee = empStack.Pop();
                Console.WriteLine($"{poppedEmployee.Id} - {poppedEmployee.Name} - {poppedEmployee.Gender} - {poppedEmployee.Salary}");
                Console.WriteLine($"Objects left in stack = {empStack.Count}");
            }
            //Lägger till objekten i stacken igen med Push();
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            //Peek(); metoden används här för att visa objekt utan att ta bort dom. Visar också hur många objekt som är kvar.
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Retreive using Peek Method");

            for (int i = 0; i < 2; i++)
            {
                Employee peekEmp = empStack.Peek();
                Console.WriteLine($"{peekEmp.Id} - {peekEmp.Name} - {peekEmp.Gender} - {peekEmp.Salary}");
                Console.WriteLine($"Objects left in stack = {empStack.Count}");
            }

            //Kontrollerar om emp3 finns i stacken och skriver ut resultat.
            Console.WriteLine("---------------------------------------------------------");
            if (empStack.Contains(emp3))
            {
                Console.WriteLine($"Emp3 is in the stack.");
            }
            else
            {
                Console.WriteLine($"Emp3 is not in the stack.");
            }

            //Skapar en lista av Emp-objekt med hjälp av Add().
            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            Console.WriteLine("---------------------------------------------------------");

            //Kontrollerar om Emp2 finns i listan med hjälp av Contains().
            Console.WriteLine("Objects in list: ");
            foreach (Employee emp in empList)
            {
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
            }

            if (empList.Contains(emp2))
            {
                Console.WriteLine("Emp2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Emp2 does not exist in the list.");
            }
            Console.WriteLine("---------------------------------------------------------");

            //Använder Find() för att skriva ut första objektet i listan som har Gender = Male.
            Employee firstMaleEmp = empList.Find(emp => emp.Gender == "Male");
            if(firstMaleEmp != null)
            {
                Console.WriteLine($"Id: {firstMaleEmp.Id}, Name: {firstMaleEmp.Name}, Gender: {firstMaleEmp.Gender}, " +
                    $"Salary: {firstMaleEmp.Salary}");
            }
            Console.WriteLine("---------------------------------------------------------");

            //Använder FindAll() för att hitta och skriva ut alla objekt i listan som har Gender = Male.
            List<Employee> maleEmp = empList.FindAll(emp => emp.Gender == "Male");
            if(maleEmp.Count > 0)
            {
                Console.WriteLine("Male employees: ");
                foreach (var maleEmployee in maleEmp)
                {
                    Console.WriteLine($"Id:  {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Salary} ");
                }
            }
           
        }
    }
}