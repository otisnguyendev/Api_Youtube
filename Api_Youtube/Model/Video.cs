using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Youtube.Model
{
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(255)]
        public string Hashtags { get; set; }

        [StringLength(255)]
        public string PrivacyLevel { get; set; } = "public";

        [Required]
        [StringLength(255)]
        public string VideoUrl { get; set; }

        [StringLength(255)]
        public string RelatedVideoIds { get; set; }

        public int DurationInSeconds { get; set; }

        public int LikesCount { get; set; } = 0;

        public int CommentsCount { get; set; } = 0;

        public int ViewsCount { get; set; } = 0;

        [Required]
        [StringLength(10)]
        public string VideoType { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Bookmark> Bookmarks { get; set; }
        public ICollection<HistoryVideo> HistoryVideos { get; set; }
    }
}