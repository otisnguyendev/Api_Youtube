using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api_Youtube.Dto;

public class LoginDto
{
    [Required]
    [MaxLength(255)]
    public string Email { get; set; }

    [Required]
    [MaxLength(255)]
    public string Username { get; set; }

    public string Token { get; set; }
}