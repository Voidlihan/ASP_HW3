using ASP_HW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_HW3.ViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}