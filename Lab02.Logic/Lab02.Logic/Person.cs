﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Logic
{
    public class Person:ILogger
    {
        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        public Person()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        void ILogger.Log(string log)
        {
            throw new NotImplementedException();
        }
    }
}
