using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsAndWarrios
{
    abstract class Character
    {
        public string CharacterType { get; set; }
        protected Character(string characterType)
        {
            CharacterType = characterType;
        }

        public abstract int DamagePoints(Character target);

        public virtual bool Vulnerable() => false;
        public override string ToString() => $"Character is a {CharacterType}";
    }
}
