namespace projeto_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroeType) : base(name, level, heroeType)
        {
            this.healPointsTotal = 150 + (level * 15);
            this.healPoints = this.healPointsTotal;
            this.manaPointsTotal = 100 + (level * 10);
            this.manaPoints = this.manaPointsTotal;
        }
        public override string Attack()
        {
            return this.name + " lançou um shuriken.";
        }
    }
}