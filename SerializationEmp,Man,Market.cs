using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializationEmpManMarket
{

    public class Employee
    {
        public int empId = 63535;
        public string empName = "Suresh Gowd s";
        public string empDesignation = "Analyst A4";

    }
    public class Manager
    {
        public int managerId = 765432;
        public String managerName = "Rahul Guptha";
        public double managerBasicPayScale = 3000000;

    }
    public class MarketingExecutive
    {
        public int markExId = 435243;
        public String markExName = "Ramesh Gowd";
        public String markExDesignation = "Sales";

    }
    internal class Serialization
    {
        static void Main(String[] args)
        {
           
            Manager manager = new Manager();
            FileStream fileStream = new FileStream(@"c:\Serialization1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();



            Employee employee = new Employee();
            FileStream fileStream1 = new FileStream(@"c:\Serialization2.txt", FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fileStream, employee);
            Console.ReadKey();

            


            MarketingExecutive marketingExecutive = new MarketingExecutive();
            FileStream fileStream2 = new FileStream(@"c:\Serialization3.txt", FileMode.Create);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(fileStream2, marketingExecutive);
            Console.ReadKey();

        }
    }
}