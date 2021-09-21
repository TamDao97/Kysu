using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Model.Comment
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int PostId { get; set; }
        public DateTime DateComment { get; set; }
        public int ApprovedStatus { get; set; }
    }
}
