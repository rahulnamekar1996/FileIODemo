using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    [Serializable]

   public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double Salary { get; set; }
    }
}
