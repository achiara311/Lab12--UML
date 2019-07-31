using System;
using System.Collections.Generic;
using System.Text;

namespace UML
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }
            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }
        public Student()
        {

        }
        public Student(string program,int year, double fee, //ctor double tab = constructor
            string name, string address)
            :base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        //virtual means you can or dont have to override method
        public override string ToString()
        {
            return $"Student: {Name}, {Address}, {Program}, {Year}, {Fee:C2}"; //carries traits over from Person abstract class
        }

    }
}
