using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge
{
    internal class Badge
    {
        public static string Print(int? id, string name, string? department)
        {
            string print = "";
            print += id != null ? $"[{id}] - " : "";
            print += $"{name} - ";
            print += department == null ? "OWNER" : department.ToUpper();

            return print;
        }
    }
}
