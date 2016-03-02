using System.Collections.Generic;
using SkillsPrototype.Stats;

namespace SkillsPrototype.Characters
{
    public abstract class Character
    {
        public IList<CharacterSkill> skills { get; private set; }

        private IList<StatValue> SkillUsage { get; set; }
    }
}