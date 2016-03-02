namespace SkillsPrototype.Skills
{
    public class SkillLevel
    {
         public int Level { get; private set; }

        public SkillLevel(int level)
        {
            Level = level;
        }

        public void AddLevel()
        {
            Level++;
        }
    }
}