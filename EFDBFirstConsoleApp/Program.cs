using EFDBFirst.Data;
using EFDBFirst.Data.Models;

public class program
{
    public static void Main()
    {

        CRUDManager obj = new CRUDManager();
        Console.WriteLine("Calling the methods !!!");

        //Console.WriteLine("Adding a new Employee");
        //obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
        //obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
        //PrintAllEmployees();


        obj.InsertTeacher(new Teacher { Name = "Abhimanyu" });

        
        Console.ReadLine();
    }

    private static void PrintAllEmployees()
    {
        Console.WriteLine("Printing all Employees");
        CRUDManager obj = new CRUDManager();
        foreach (Employee employee in obj.GetAllEmployees())
        {
            Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        }
    }

}