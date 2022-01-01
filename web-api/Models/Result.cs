using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Models
{
    public class Result
    {
        //Fields
        //----------------------------------------
        //Id is important for Databases
        //public int Id { get; set; }
        public int Value { get; set; }


        //Constructor
        //----------------------------------------
        public Result(int value)
        {
            Value = value; 
        }

    }
}
