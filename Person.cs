using System;
using System.Collections.Generic;
using System.Text;

namespace UML
{
    abstract class Person
    {
        private protected string Name { get; set; } //private --can only use in this class
        private protected string Address {get; set;}//protected---anything inherited is allowed 
        //to pass through, even if private is infront of protected.

        public Person()
        {

        }
        protected Person(string _name, string _address)
        {
            Name = _name;
            Address = _address;
        }
        

        public override string ToString() //without this, itll display list name as just the Classes 
            //from where theyre coming from 
        {
            return $"Person: {Name}, {Address}";
        }

        

    }

        

}
