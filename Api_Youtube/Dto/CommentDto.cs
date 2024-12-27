namespace Api_Youtube.Dto;

public class CommentDto
{
    public int VideoId { get; set; }
    public string Content { get; set; }
    public int? CommentId { get; set; }
}