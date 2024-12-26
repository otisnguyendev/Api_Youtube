using System.ComponentModel.DataAnnotations;

namespace Api_Youtube.Dto;

public class UpdateProfileDto
{
    [MaxLength(255)]
    public string? Username { get; set; }
    [MaxLength(255)]
    public string? Bio { get; set; }
    public IFormFile? Avatar { get; set; }
}