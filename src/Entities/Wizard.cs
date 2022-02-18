namespace projeto_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroeType) : base(name, level, heroeType)
        {
            this.healPointsTotal = 150 + (level * 10);
            this.healPoints = this.healPointsTotal;
            this.manaPointsTotal = 200 + (level * 15);
            this.manaPoints = this.manaPointsTotal;
        }

        public override string Attack()
        {
            return this.name + " lançou uma magia.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
                return this.name + " lançou uma magia super efetiva com bonus de ataque de " + Bonus;
            else
            {
                return this.name + " lançou uma magia fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}