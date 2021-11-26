using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbContext.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Education { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
