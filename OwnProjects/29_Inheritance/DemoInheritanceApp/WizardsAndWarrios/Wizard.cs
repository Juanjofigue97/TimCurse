using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsAndWarrios
{
    internal class Wizard : Character
    {
        private bool isSpellPrepared { get; set; }
        public Wizard() : base("Wizard")
        {
            isSpellPrepared = false;
        }

        public override int DamagePoints(Character target) => isSpellPrepared ? 12 : 3;

        public void PrepareSpell() => isSpellPrepared = true;

        public override bool Vulnerable() => !isSpellPrepared;
    }
}


