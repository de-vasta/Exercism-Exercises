using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException()
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        int => $"There are {report} supporters at the match.",
        string => (string)report,
        Foul => ((Foul)report).GetDescription(),
        Injury => $"Oh no! {((Injury)report).GetDescription()} Medics are on the field.",
        Incident => ((Incident)report).GetDescription(),
        Manager manager => manager.Name + (manager.Club == null ? "" : $" ({manager.Club})"),
        _ => throw new ArgumentException()
    };
}
