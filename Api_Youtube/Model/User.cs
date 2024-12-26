using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_Youtube.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(255)]
        public string Username { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        [StringLength(255)]
        public string Bio { get; set; }

        public ICollection<Video> Videos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Follower> Followers { get; set; }
        public ICollection<Follower> Following { get; set; }
        public ICollection<Bookmark> Bookmarks { get; set; }
        public ICollection<HistoryVideo> HistoryVideos { get; set; }
    }
}