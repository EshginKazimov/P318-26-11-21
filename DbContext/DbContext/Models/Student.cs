using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbContext.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Fullname { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return $"{Id} {Fullname} {Group.Name} {Group.Education}";
        }
    }
}
