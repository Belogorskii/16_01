using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StringReader sr = new StringReader("../../../Employees.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Employee Employees = JsonSerializer.Deserialize<Employee[]>(jsonString);

            Employee maxEmployee = employees[0];
            foreach (Employee e in employees)
            {
                if (e.Summa > maxEmployee.Summa)
                {
                    maxEmployee = e;
                }
            }
            Console.WriteLine($"{maxEmployee.Num} {maxEmployee.Name} {maxEmployee.Summa}");
            Console.ReadKey();
        }
    }
}
