using ASP_HW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_HW3.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        // _CreatePartial.cshtml
        public TeacherViewModel CreateTeacherViewModel { get; set; }
    }
}