using Kysu.DB.DuLich.Model.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kysu.DB.DuLich.Entities
{
    /// <summary>
    /// Bài đăng
    /// </summary>
    public partial class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(500)]
        public string Title { get; set; }

        [Required, StringLength(500)]
        public string Sapo { get; set; }

        [Required]
        public string Content { get; set; }

        public string Image { get; set; }

        [Required]
        public int Status { get; set; }

        [Required, MaxLength(36)]
        public string CreateBy { get; set; }

        [Required, MaxLength(36)]
        public string UpdateBy { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Updated { get; set; }

        public int TouristPlaceId { get; set; }
    }

    public partial class Post
    {
        public Post Clone(PostModel model)
        {
            return new Post
            {
                Id = model.Id,
                Title = model.Title,
                Content = model.Content,
                Sapo = model.Sapo,
                Status = model.Status,
                TouristPlaceId = model.TouristPlaceId,
                Image = model.Image,
                CreateBy = model.CreateBy,
                Created = model.Created,
                UpdateBy = model.UpdateBy,
                Updated = model.Updated
            };
        }
    }
}
