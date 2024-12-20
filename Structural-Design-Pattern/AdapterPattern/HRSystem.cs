using System;
using System.Collections.Generic;
using System.Text.Json;

namespace AdapterPattern
{
    /* Craete a system that supports lagecy systems
    TODO*************************************************************
    1. Hr Submt Employee salary in a string Format
    2. Thir-party systems only accept List of Objects
    3. We have make an adapter so that system works fine for both cases without modifying existing code.
    */
    public class Employee
    {
        public Employee(int id, string name, string designation, decimal salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Designation { get; private set; }
        public decimal Salary { get; private set; }
    }

    // Adaptee: which is legacy systems that systems should handle
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
        public void ProcessSalary(List<Employee> listOfEmployee)
        {
            Console.WriteLine(JsonSerializer.Serialize(listOfEmployee));
        }
    }

// adapter interface
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }

    // concrete Adapter
    public class EmployeeAdapter : ITarget
    {
        private readonly ThirdPartyBillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;
            var listEmployee = new List<Employee>();
            for (var i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (var j = 0; j < employeesArray.GetLength(1); j++)
                    if (j == 0)
                        Id = employeesArray[i, j];
                    else if (j == 1)
                        Name = employeesArray[i, j];
                    else if (j == 2)
                        Designation = employeesArray[i, j];
                    else
                        Salary = employeesArray[i, j];
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }

            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}