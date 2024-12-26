using System.ComponentModel.DataAnnotations;

namespace Api_Youtube.Dto;

public class ChangePasswordDto
{
    [MaxLength(100)]
    public string OldPassword { get; set; }
    [MaxLength(100)]
    public string NewPassword { get; set; }
}