namespace Api_Youtube.Dto;

public class UpdateProfileDto
{
    public string? Username { get; set; }
    public string? Bio { get; set; }
    public IFormFile? Avatar { get; set; }
}