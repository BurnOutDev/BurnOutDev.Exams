using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurnOutDev.Exams.Web.DAL.Models
{
    public class AnswerEntity : Entity
    {
        public long AnswerID { get; set; }
        public bool IsCorrect { get; set; }
        public AnswerType Type
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(TextContent) && PictureContent != null)
                    return AnswerType.TextPicture;
                else if (!string.IsNullOrWhiteSpace(TextContent))
                    return AnswerType.Text;
                else if (PictureContent != null)
                    return AnswerType.Picture;
                else
                    return AnswerType.Empty;
            }
        }
        public string TextContent { get; set; }
        public byte[] PictureContent { get; set; }
        public QuestionEntity Question { get; set; }
    }

    public enum AnswerType
    {
        Text,
        Picture,
        TextPicture,
        Empty
    }
}