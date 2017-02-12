using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurnOutDev.Exams.Web.DAL.Models
{
    public class QuestionEntity : Entity
    {
        public int QuestionID { get; set; }
        public string Title { get; set; }
        public QuestionType Type
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(TextContent) && PictureContent != null)
                    return QuestionType.TextPicture;
                else if (!string.IsNullOrWhiteSpace(TextContent))
                    return QuestionType.Text;
                else if (PictureContent != null)
                    return QuestionType.Picture;
                else
                    return QuestionType.Empty;
            }
        }
        public string TextContent { get; set; }
        public byte[] PictureContent { get; set; }
        public virtual ICollection<AnswerEntity> Answers { get; set; }
    }

    public enum QuestionType
    {
        Text,
        Picture,
        TextPicture,
        Empty
    }
}