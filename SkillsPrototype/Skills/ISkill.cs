using System.Collections.Generic;
using SkillsPrototype.Stats;
using SkillsPrototype.Utility;

namespace SkillsPrototype.Skills
{
    public interface ISkill
    {
        UniqueId Uid { get; }
        string Name{get;}
        IList<StatValue> SynergyStats { get; }
        IList<StatValue> MinStats { get; }
        IList<StatValue> StatBonus { get; }
    }
}