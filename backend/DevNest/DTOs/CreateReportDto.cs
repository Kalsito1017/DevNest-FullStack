using System.ComponentModel.DataAnnotations;

public class CreateReportDto
{
    [Required]
    [StringLength(50)]
    public string Reason { get; set; } = "";

    [Required]
    [StringLength(500, MinimumLength = 10)]
    public string Details { get; set; } = "";

    [EmailAddress]
    [StringLength(254)]
    public string? Email { get; set; }

    public int? JobId { get; set; }

    [StringLength(500)]
    public string? PageUrl { get; set; }
}
