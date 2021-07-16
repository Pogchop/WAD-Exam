using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Exam.Models;

namespace Exam.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("Exam_WAD")
        {
        }

        public System.Data.Entity.DbSet<Exam.Models.Classroom> Classrooms { get; set; }

        public System.Data.Entity.DbSet<Exam.Models.ExamSubject> ExamSubjects { get; set; }

        public System.Data.Entity.DbSet<Exam.Models.Test> Tests { get; set; }

        public System.Data.Entity.DbSet<Exam.Models.Falculty> Falculties { get; set; }
    }
}