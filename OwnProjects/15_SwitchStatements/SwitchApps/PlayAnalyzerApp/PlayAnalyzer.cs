using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlayAnalyzerApp;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        string output = shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException(),
        };

        return output;
    }

    public static string AnalyzeOffField(object report)
    {
        
        Incident incident = report as Incident;

        if (incident is Foul)
        {
            return incident.GetDescription();
        }
        else if (incident is Injury)
        {
            return $"Oh no! {incident.GetDescription()} Medics are on the field.";
        }
        else if (incident is Incident)
        {
            return incident.GetDescription();
        }

        var manager = report as Manager;

        if (manager is not null)
        {
            if (manager.Club is not null)
            {
                return $"{manager.Name} ({manager.Club})";
            }

            return manager.Name;
        }

        if ((report is string) || (report is int))
        {
            var isNumber = int.TryParse(report.ToString(), out int number);

            if (isNumber)
            {
                return $"There are {number} supporters at the match.";
            }
            else
            {
                return report.ToString()!;
            }

        }
        throw new ArgumentException();
    }
}


//public static class PlayAnalyzer
//{
//    public static string AnalyzeOnField(int shirtNum)
//    {
//        string output = shirtNum switch
//        {
//            1 => "goalie",
//            2 => "left back",
//            3 or 4 => "center back",
//            5 => "right back",
//            6 or 7 or 8 => "midfielder",
//            9 => "left wing",
//            10 => "striker",
//            11 => "right wing",
//            _ => throw new ArgumentOutOfRangeException(),
//        };

//        return output;
//    }

//    public static string AnalyzeOffField(object report)
//    {
//        var incident = report as IIncident;

//        if (incident != null)
//        {
//            return incident.Message;
//        }


//        if ((report is string) || (report is int))
//        {
//            var isNumber = int.TryParse(report.ToString(), out int number);

//            if (isNumber)
//            {
//                return $"There are {number} supporters at the match.";
//            }
//            else
//            {
//                return report.ToString()!;
//            }

//        }

//        throw new ArgumentException();
//    }

//}
//public class Foul : IIncident
//{
//    public string Message => "The referee deemed a foul.";
//}
//public class Incident : IIncident
//{
//    public string Message => "An incident happened.";
//}
//public class Injury : IIncident
//{
//    public int _player;
//    public Injury(int player)
//    {
//        _player = player;
//    }
//    public string Message => $"Oh no! Player {_player} is injured. Medics are on the field.";

//}
//public class Manager : IIncident
//{
//    public string _nameCoach;
//    public string _nameTeam;
//    public Manager(string NameCoach, string NameTeam)
//    {
//        _nameCoach = NameCoach;
//        _nameTeam = NameTeam;
//    }
//    //public string Message => $"{ _nameCoach } ({_nameTeam})";
//    public string Message
//    {
//        get
//        {
//            if (_nameTeam is null)
//            {
//                return _nameCoach;
//            }
//            else
//            {
//                return $"{_nameCoach} ({_nameTeam})";
//            }
//        }
//    }

//}

//public interface IIncident
//{
//    public string Message { get; }
//}
//private static string Foul() => "The referee deemed a foul.";
