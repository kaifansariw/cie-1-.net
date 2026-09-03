namespace CollegeFestMVC.Extensions;

public static class ParticipantExtensions
{
    public static string GetRegistrationStatus(this Participant participant)
    {
        return participant.IsRegistrationCompleted ? "Confirmed" : "Pending";
    }

    public static decimal GetRegistrationFee(this Participant participant)
    {
        return participant.EventName switch
        {
            "Hackathon" => 500m,
            "Coding Challenge" => 300m,
            "Web Design" => 250m,
            "Tech Quiz" => 0m,
            _ => 100m
        };
    }

    public static string GetFeeCategory(this Participant participant)
    {
        var fee = participant.GetRegistrationFee();

        return fee switch
        {
            0m => "Free Event",
            <= 300m => "Standard Event",
            _ => "Premium Event"
        };
    }
}
