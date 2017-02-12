using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurnOutDev.Exams.Web.Models
{
    public class QuestionViewModel
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
        public ICollection<AnswerViewModel> Answers { get; set; }
    }

    public enum QuestionType
    {
        Text,
        Picture,
        TextPicture,
        Empty
    }

    public class AnswerViewModel
    {
        public long AnswerID { get; set; }
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
        public QuestionViewModel Question { get; set; }
    }

    public enum AnswerType
    {
        Text,
        Picture,
        TextPicture,
        Empty
    }

    public class ExamViewModel
    {
        public int ExamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public ICollection<QuestionViewModel> Questions { get; set; }

        public ExamResult Results { get; set; }
    }

    public class ExamResult
    {
        public int ResultID { get; set; }
        public string Username { get; set; }
        public int[] CheckedAnswerIDs { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public DateTime StartDate { get; set; }
    }
}