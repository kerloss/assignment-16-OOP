using assignment_16.Inheritance;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Linq;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Buffers.Text;
using System.Diagnostics;
using System.Globalization;
using System.Timers;

namespace assignment_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            #region Indexer
            //PhoneBook phone = new PhoneBook(3);

            //phone.AddPerson(0, "kerloss", 123);
            //phone.AddPerson(1, "maha", 456);
            //phone.AddPerson(2, "omar", 789);

            ////without Indexer
            //phone.SetNumberOfPhoneBook("omar", 9999);
            //Console.WriteLine(phone.GetNumberOfPhoneBook("omar"));

            ////with Indexer
            //phone["omar"] = 5555;   //set
            //Console.WriteLine(phone["omar"]);   //get

            //for (int i = 0; i < phone.Size; i++)
            //{
            //    Console.WriteLine(phone[i]);
            //} 
            #endregion

            #region Class
            //Car C1 = new Car(10, "BMW", 320);

            //Console.WriteLine(C1.ToString());

            //C1 = new Car(20, "Verna");
            //C1 = new Car(30); 
            #endregion

            #region Inhertiance
            //Parent P1 = new Parent(1,2);

            //Console.WriteLine(P1.Product());
            //Console.WriteLine(P1);
            //Console.WriteLine(P1.ToString());

            //Child C1 = new Child(1,2,3);

            //Console.WriteLine(C1.Product());
            //Console.WriteLine(C1.ToString());
            #endregion
            #endregion

            #region part 2
            #region question 1
            //1.Design and implement a Class for the employees in a company:
            //Employee is identified by an ID, Name, security level, salary, hire date and Gender.

            //Employee employee = new Employee();

            //employee.Id = 1;
            //employee.Name = "kerloss";
            //employee.SecurityLevel = 2;
            //employee.Salary = 5000;
            //employee.HireDate = DateTime.Now;
            //employee.Gender = Gender.Male;

            //Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nSecurityLevel: {employee.SecurityLevel} \nSalary: {employee.Salary} \nHireDate: {employee.HireDate} \nGender: {employee.Gender}");
            #endregion

            #region question 2
            //2.Develop a Class to represent the Hiring Date Data:
            //consisting of fields to hold the day, month and Years.

            //Employee employee = new Employee();

            //employee.Id = 2;
            //employee.Name = "emeil";
            //employee.SecurityLevel = 3;
            //employee.Salary = 50000;
            //employee.Date = new HiringDate(8, 6, 2024);
            ////HiringDate hiringDate = new HiringDate(8,6,2024);
            ////hiringDate.DisplayHiringDate();
            //employee.Gender = Gender.Male;

            //Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nSecurityLevel: {employee.SecurityLevel} \nSalary: {employee.Salary} \nHireDate: {employee.Date} \nGender: {employee.Gender}");
            #endregion

            #region question 3
            //3.We need to restrict the Gender field to be only M or F[Male or Female]

            //Employee employee = new Employee();

            //employee.Id = 3;
            //employee.Name = "ahmed";
            //employee.SecurityLevel = 5;
            //employee.Salary = 9000;
            //employee.Date = new HiringDate(6, 6, 2024);
            //employee.Gender = Gender.Male;

            //Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nSecurityLevel: {employee.SecurityLevel} \nSalary: {employee.Salary} \nHireDate: {employee.Date} \nGender: {employee.Gender}");
            #endregion

            #region question 4
            //4.Assign the following security privileges to the employee(guest, Developer, secretary and DBA)
            //in a form of Enum

            //Employee employee = new Employee();

            //employee.Id = 4;
            //employee.Name = "mazin";
            //employee.SecurityLevel = 8;
            //employee.Privilege = SecurityPrivilege.Developer;
            //employee.Salary = 7000;
            //employee.Date = new HiringDate(12,12,2012);
            //employee.Gender = Gender.Male;

            //Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nSecurityLevel: {employee.SecurityLevel} \nSecurityPrivilege: {employee.Privilege} \nSalary: {employee.Salary} \nHireDate: {employee.Date} \nGender: {employee.Gender}");
            #endregion

            #region question 5
            //5.We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //display employee salary in a currency format. [use String.Format Function]

            //Employee employee = new Employee();

            //employee.Id = 5;
            //employee.Name = "nour";
            //employee.SecurityLevel = 9;
            //employee.Privilege = SecurityPrivilege.DBA;
            //employee.Salary = 9000;
            //employee.Date = new HiringDate(12, 5, 2024);
            //employee.Gender = Gender.Male;

            //Console.WriteLine(employee.ToString());
            #endregion

            #region question 6
            //6.Create an array of Employees with size three a DBA, Guest and the third one is security 
            //officer who have full permissions. (Employee[] EmpArr;)

            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "kerloss", 2, 5000, new HiringDate(12,5,2024) , Gender.Male, SecurityPrivilege.Developer);
            //EmpArr[1] = new Employee(2, "mazin", 3, 6000, new HiringDate(8,6,2024) , Gender.Male, SecurityPrivilege.DBA);
            //EmpArr[2] = new Employee(3, "nour", 4, 7000, new HiringDate(12,12,2012) , Gender.Male, SecurityPrivilege.Secretary);

            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i].ToString());
            //}
            #endregion

            #region question 7
            //1.Sort the employees based on their hire date then Print the sorted array.
            //While sorting(how many times Boxing and Unboxing process has occurred)

            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "kerloss", 2, 5000, new HiringDate(12, 5, 2024), Gender.Male, SecurityPrivilege.Developer);
            //EmpArr[1] = new Employee(2, "mazin", 3, 6000, new HiringDate(8, 6, 2024), Gender.Male, SecurityPrivilege.DBA);
            //EmpArr[2] = new Employee(3, "nour", 4, 7000, new HiringDate(12, 12, 2012), Gender.Male, SecurityPrivilege.Secretary);

            ////count boxing and unboxing
            //int boxingCount = 0;
            //int unBoxingCount = 0;

            ////sort array
            //Array.Sort(EmpArr, (emp1, emp2) =>
            //{
            //    boxingCount += 2;

            //    int result = emp1.HireDate.CompareTo(emp2.HireDate);

            //    unBoxingCount += 2;

            //    return result;
            //});

            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine($"\n{EmpArr[i].ToString()}");
            //}

            //Console.WriteLine($"\nBoxing operation: {boxingCount}");
            //Console.WriteLine($"UnBoxing operation: {unBoxingCount}");
            #endregion
            #endregion
        }
    }
}
