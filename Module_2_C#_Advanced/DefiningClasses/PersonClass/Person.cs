﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name; 
            set => name = value;
        }

        public int Age
        {
            get => age; 
            set => age = value;
        }

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age) : this()
        {
            this.age = age;
        }

        
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        
    }
}
