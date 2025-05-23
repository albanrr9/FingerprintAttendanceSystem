﻿using AttendanceSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace AttendanceSystem.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string ProfessorID { get; set; }
        public ApplicationUser Professor { get; set; }
        public ICollection<Attendance> Attendances { get; set; }

    }
}
