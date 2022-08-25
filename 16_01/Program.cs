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
        private static JavaScriptEncoder Encoder;

        static void Main(string[] args)
        {
            const int n = 5;
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите номер");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите Размер заработной платы");
                int suma = Convert.ToInt32(Console.ReadLine());
                employees[i] = new Employee() { Num = num, Name = name, Suma = suma };
            }

            JsonSerializerOptions options = new JsonSerializerOptions();
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
            }
            string jsonString = JsonSerializer.Serialize(employees, options);

            using (StreamWriter sw = new StreamWriter("../../../Employees.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}