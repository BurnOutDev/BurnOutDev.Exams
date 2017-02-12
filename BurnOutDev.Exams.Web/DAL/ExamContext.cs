using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BurnOutDev.Exams.Web.DAL
{
    public class ExamContext : DbContext
    {
        public ExamContext() : base("ExamDatabase")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ExamContext>());
        }
    }
}