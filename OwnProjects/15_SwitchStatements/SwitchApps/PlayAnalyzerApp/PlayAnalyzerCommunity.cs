using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAnalyzerApp
{
    public static class PlayAnalyzerCommunity
    {
        public static string AnalyzeOnField(int shirtNum) =>
            (playerDescriptionForNumber.ContainsKey(shirtNum))
                ? playerDescriptionForNumber[shirtNum]
                : throw new ArgumentOutOfRangeException(nameof(shirtNum), $"Not expected shirt number: {shirtNum}");
        public static string AnalyzeOffField(object report) => report switch
        {
            int supporters => $"There are {supporters} supporters at the match.",
            String announcement => announcement,
            Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
            Incident incident => incident.GetDescription(),
            Manager manager => ManagerDescription(manager),
            _ => throw new ArgumentException(nameof(report), $"Not expected data type: {report}")
        };
        #region Helper methods
        private static string ManagerDescription(Manager manager) => (manager.Club is null) ? manager.Name : $"{manager.Name} ({manager.Club})";
        #endregion
        #region Fixed values
        private static readonly Dictionary<int, string> playerDescriptionForNumber = new Dictionary<int, string>
    {
        {1, "goalie"},
        {2, "left back"},
        {3, "center back"},
        {4, "center back"},
        {5, "right back"},
        {6, "midfielder"},
        {7, "midfielder"},
        {8, "midfielder"},
        {9, "left wing"},
        {10, "striker"},
        {11, "right wing"}
    };
        #endregion
    }
}
