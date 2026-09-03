using Microsoft.AspNetCore.Mvc;

namespace CollegeFestMVC.Controllers;

public class FestController : Controller
{
    private static readonly List<Participant> Participants = new()
    {
        new Participant
        {
            ParticipantId = 1,
            ParticipantName = "Demo Student",
            Email = "student@example.com",
            Department = "Computer Engineering",
            Year = 3,
            EventName = "Hackathon",
            IsTeamEvent = true,
            IsRegistrationCompleted = true
        }
    };

    public IActionResult Index()
    {
        return View(Participants);
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Participant participant)
    {
        if (!ModelState.IsValid)
            return View(participant);

        participant.ParticipantId = Participants.Count == 0
            ? 1
            : Participants.Max(p => p.ParticipantId) + 1;

        participant.IsRegistrationCompleted = true;
        Participants.Add(participant);

        return RedirectToAction(nameof(Details), new { id = participant.ParticipantId });
    }

    public IActionResult Details(int id)
    {
        var participant = Participants.FirstOrDefault(p => p.ParticipantId == id);

        if (participant == null)
            return NotFound();

        return View(participant);
    }

    public IActionResult Welcome()
    {
        return View();
    }
}
