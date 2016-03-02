using SkillsPrototype.Stats;

namespace SkillsPrototype.Stats
{
    public class StatValue
    {
        public IStat Stat { get; private set; }
        public int Value { get; private set; }

        public StatValue(IStat stat, int value)
        {
            Stat = stat;
            Value = value;
        }
    }
}