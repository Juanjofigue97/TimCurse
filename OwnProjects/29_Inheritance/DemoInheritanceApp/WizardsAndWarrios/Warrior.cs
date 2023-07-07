using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsAndWarrios
{
    internal class Warrior : Character
    {
        public Warrior() : base("Warrior")
        {
        }

        public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
    }
}
