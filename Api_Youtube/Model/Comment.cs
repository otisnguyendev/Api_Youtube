using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Youtube.Model
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("Video")]
        [Column("video_id")]    
        public int VideoId { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public User User { get; set; }
        public Video Video { get; set; }
    }
}