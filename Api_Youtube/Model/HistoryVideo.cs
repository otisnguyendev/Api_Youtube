using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Youtube.Model
{
    public class HistoryVideo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Video")]
        public int VideoId { get; set; }

        public DateTime ViewTime { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Video Video { get; set; }
    }
}