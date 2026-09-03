using System.ComponentModel.DataAnnotations;

namespace CollegeFestMVC.Models;

public class Participant
{
    public int ParticipantId { get; set; }

    [Required]
    public string ParticipantName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Department { get; set; } = string.Empty;

    [Required]
    public int? Year { get; set; }

    [Required]
    public string EventName { get; set; } = string.Empty;

    public bool IsTeamEvent { get; set; }

    public bool IsRegistrationCompleted { get; set; } = true;
}
