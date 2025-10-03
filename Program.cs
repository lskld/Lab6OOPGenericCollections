//Theo Lilliesköld NET25

namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PART 1 (STACK)

            var employeeStack = new Stack<Employee>();

            var employee1 = new Employee("ID4034", "Jonas", "Male", 45000m);
            var employee2 = new Employee("ID7281", "Anna", "Female", 39500m);
            var employee3 = new Employee("ID5127", "Erik", "Male", 56200m);
            var employee4 = new Employee("ID9462", "Sara", "Female", 42100m);
            var employee5 = new Employee("ID3845", "Lars", "Male", 51000m);

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("Retrieve entire Stack:");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\nRetrieve using Pop Method:");
            for (int i = employeeStack.Count; i > 0; i--)
            {
                Console.WriteLine(employeeStack.Pop());
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\nRetrieve using Peek Method:");

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(employeeStack.Peek());
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            Console.WriteLine("\n-------------------------------------");
            var array = employeeStack.ToArray();
            
            if(array.Length > 3)
            {
                Console.WriteLine("\nObject 3 is in Stack");
            }
            else
            {
                Console.WriteLine("\nObject number 3 is not in Stack");
            }


            //PART 2 (LIST)

            Console.WriteLine("\n-------------------------------------\n");
            var employeeList = new List<Employee>();

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            if (employeeList.Contains(employee2))
                Console.WriteLine("Employee2 object exists in the list");
            else
                Console.WriteLine("Employee2 o  bject does not exist in the list");

            Console.WriteLine($"\n{employeeList.Find(employee => employee.Gender == "Male")}\n");

            var males = employeeList.FindAll(employee => employee.Gender == "Male");
            foreach (var male in males)
            {
                Console.WriteLine(male);
            }

        }
    }
}
