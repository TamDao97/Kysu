using Kysu.DB.DuLich.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kysu.DB.DuLich.Entities
{
    public partial class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required, MaxLength(500)]
        public string UserName { get; set; }

        [Required, MaxLength(500)]
        public string Password { get; set; }

        public string Avatar { get; set; }

        public int Type { get; set; }
    }

    public partial class User
    {
        public User Clone(UserModel model)
        {
            return new User
            {
                Id = model.Id,
                UserName = model.UserName,
                Password = model.Password,
                Avatar = model.Avatar,
                Type = model.Type
            };
        }
    }
}
