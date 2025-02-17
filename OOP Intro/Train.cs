using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{

    public abstract class Employee
    {
        public string Name { get; private set; } = "";
        public int Age { get; private set; }
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void LogHours();

    }

    public class Driver : Employee
    {
        public Driver(string name, int age) : base (name, age)
        {
            
        }

        public void HonkHorn()
        { 
            Console.WriteLine("Chugga Chugga Choo Choo!");
        }

        public override void LogHours()
        {
            Console.WriteLine("8 Hours, 30pph");
        }
    }

    public class Vendor : Employee
    {
        public Vendor(string name, int age) : base(name,age)
        {

        }

        public void Sell()
        {
            Console.WriteLine("+ 5$");
        }

        public override void LogHours()
        {
            Console.WriteLine("8 Hours, 15pph");
        }
    }
    public class Inspector : Employee
    {
        public Inspector(string name, int age) : base(name, age)
        {

        }

        public void Catch()
        {
            Console.WriteLine("A person who didn't pay the fare has been caught.");
        }

        public override void LogHours()
        {
            Console.WriteLine("8 Hours, 20pph");
        }
    }

    public class Engine
    {
        public string EngineType { get; private set; }
        public bool IsRunning { get; private set; }

        public Engine(string engineType)
        {
            EngineType = engineType;
            IsRunning = false;
        }

        public void Start()
        {
            IsRunning = true;
            Console.WriteLine($"The {EngineType} engine is now running.");
        }

        public void Stop()
        {
            IsRunning = false;
            Console.WriteLine("The engine has been turned off.");
        }
    }

    public class Train
    {
        private List<Employee> Employees;

        private Engine Engine;
        public string Name { get; private set; } = "";
        public List<string> Lines { get; private set; } = [];
        public int PassengerCount { get; private set; } = 0;
        public int StaffCount { get; private set; } = 0;
        public List<string> Platforms { get; private set; } = [];

        public Train(string name, List<string> lines, List<string> platforms, Engine engine)
        {
            Name = name;
            Lines = lines;
            Platforms = platforms;
            Engine = engine;
        }

        public void AddPassenger()
        {
            PassengerCount++;
        }

        public void RemovePassenger()
        {
            PassengerCount--;
        }

        public void Start()
        {
            Console.WriteLine($"{Name} starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} stopping...");
        }
        /*
        public void DisablePlatform(string platform)
        {
            Platforms.Remove(platform);
        }

        public void EnablePlatform(string platform)
        {
            Platforms.Remove(platform);
        }*/

        public void AddDriver(Driver driver)
        {
            Employees.Add(driver);
            StaffCount += 1;
        }

        public void AddVendor(Vendor vendor)
        {
            Employees.Add(vendor);
            StaffCount += 1;
        }

        public void AddInspector(Inspector inspector)
        {
            Employees.Add(inspector);
            StaffCount += 1;
        }

        public void FireEmployee(Employee employee)
        {
            Employees.Remove(employee);
            StaffCount -= 1;
        }
    }



    /*
    public class TrainStation
    {
        private List<Employee> _employees;

        private Shop _shop;
        public string Name { get; private set; } = "";
        public List<string> Lines { get; private set; } = [];
        public int PassengerCount { get; private set; } = 0;
        public string Opening { get; private set; }
        public string Closing { get; private set; }
        public List<string> Trains { get; private set; } = [];
        public int StaffCount { get; private set; } = 0;
        public List<string> Platforms { get; private set; } = [];
        public string Location { get; private set; } = "";

        public TrainStation(string name, List<string> lines, string opening, string closing, string location, List<string> platforms)
        {
            Name = name;
            Lines = lines;
            Opening = opening;
            Closing = closing;
            Location = location;
            Platforms = platforms;
        }

        public void AddPassenger()
        {
            PassengerCount++;
        }

        public void RemovePassenger()
        {
            PassengerCount--;
        }

        public void AddTrain(string train)
        {
            Trains.Add(train);
        }
        public void DisablePlatform(string platform)
        {
            Platforms.Remove(platform);
        }

        public void EnablePlatform(string platform)
        {
            Platforms.Remove(platform);
        }

        public void HireEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void FireEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }
    }*/
}
