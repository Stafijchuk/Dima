using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2._17.Models.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}