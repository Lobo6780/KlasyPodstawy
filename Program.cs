using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int studentNumber, average;
        public bool isLigibleToEnroll() { return true; }
        public int getSeminarsTaken() { return 1; }
    }

    class Professor
    {
        public int salary, staffNumber, numberOfClasses;
        private int yearsOfService;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Bartosz";
            p1.phoneNumber = "123456789";
            p1.emailAddress = "test@test.test";

            p1.lives_at = new Address();

            p1.lives_at.street = "28 czerwca";
            p1.lives_at.city = "Poznań";
            p1.lives_at.state = "Wlkp";

            p1.purchaseParkingPass();


        }
    }
}
