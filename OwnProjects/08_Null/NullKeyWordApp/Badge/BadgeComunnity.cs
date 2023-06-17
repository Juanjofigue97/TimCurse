using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge
{
    internal class BadgeComunnity
    {
        private const string DefaultDerpartment = "owner";
        public static string Print(int? id, string name, string? department)
        {
            department = (department ?? DefaultDerpartment).ToUpper();
            return id.HasValue switch
            {
                true => $"[{id}] - {name} - {department}",
                false => $"{name} - {department}",
            };
        }
    }
}
