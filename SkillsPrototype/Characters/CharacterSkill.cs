using SkillsPrototype.Skills;

namespace SkillsPrototype.Characters
{
    public class CharacterSkill
    {
        public ISkill Skill { get; private set; }
        public SkillLevel Level { get; private set; }
        public Affinity CurrentAffinity { get; private set; }

        public CharacterSkill(ISkill skill, SkillLevel level, Affinity currentAffinity)
        {
            Skill = skill;
            Level = level;
            CurrentAffinity = currentAffinity;
        }
    }
}