using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurnOutDev.Exams.Web.DAL.Models
{
    public class ExamEntity : Entity
    {
        [Key]
        public int ExamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public virtual ICollection<QuestionEntity> Questions { get; set; }
    }
}