using Kysu.DB.DuLich.Model.Comment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kysu.DB.DuLich.Entities
{
    /// <summary>
    /// Bình luận, phản hồi
    /// </summary>
    public partial class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(36)]
        public string UserId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        public DateTime DateComment { get; set; }

        [Required]
        public int ApprovedStatus { get; set; }
    }

    public partial class Comment
    {
        public Comment Clone(CommentModel model)
        {
            return new Comment
            {
                Id = model.Id,
                PostId = model.PostId,
                UserId = model.UserId,
                DateComment = model.DateComment,
                ApprovedStatus = model.ApprovedStatus
            };
        }
    }
}
