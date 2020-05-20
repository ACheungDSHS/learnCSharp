using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class Teacher : Person
        public enum type
        {
            HEADOFDEPARTMENT, HEADTEACHER, HEADOFYEAR
        };
    {
        String location;
        public Teacher(String name, String location) : base(name, Person.type.TEACHER)
        {
            this.location = location;
            
        }
    }
}
