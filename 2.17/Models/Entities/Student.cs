using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2._17.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public virtual Group Group { get; set; }
        public int GroupId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}