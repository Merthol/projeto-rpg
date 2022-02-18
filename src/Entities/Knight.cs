namespace projeto_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroeType) : base(name, level, heroeType)
        {
            this.healPointsTotal = 300 + (level * 20);
            this.healPoints = this.healPointsTotal;
            this.manaPointsTotal = 30 + (level * 5);
            this.manaPoints = this.manaPointsTotal;
        }

        public override string Attack()
        {
            return this.name + " atacou com sua espada.";
        }
    }
}