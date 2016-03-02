using System.Collections.Generic;
using SkillsPrototype.Stats;
using SkillsPrototype.Utility;

namespace SkillsPrototype.Skills
{
    public abstract class Skill : ISkill
    {
        public UniqueId Uid { get; private set; }
        public string Name { get; private set; }
        public IList<StatValue> SynergyStats { get; private set; }
        public IList<StatValue> MinStats { get; private set; }
        public IList<StatValue> StatBonus { get; private set; }


        protected Skill(UniqueId uid, string name, IList<StatValue> synergyStats,
            IList<StatValue> minStats, IList<StatValue> statBonus)
        {
            Uid = uid;
            Name = name;
            SynergyStats = synergyStats;
            MinStats = minStats;
            StatBonus = statBonus;
        }


    }
}