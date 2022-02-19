namespace projeto_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, string heroeType) : base(name, heroeType)
        {
            this.primaryAttributes.strength = 1;
            this.primaryAttributes.intelligence = 7;
            this.primaryAttributes.agility = 2;
            this.primaryAttributes.vitality = 3;
            this.UpdateStatus();
            this.UpdateTotalHealMana();
            this.healPoints = this.healPointsTotal;
            this.manaPoints = this.manaPointsTotal;
        }

        protected override void UpdateTotalHealMana()
        {
            this.healPointsTotal = 80 + (level * 10) + this.primaryAttributes.vitality * 3;
            this.manaPointsTotal = 50 + (level * 15) + this.primaryAttributes.intelligence * 4;
        }

        public virtual void LevelUp()
        {
            this.level++;
            this.primaryAttributes.strength = this.primaryAttributes.strength + 2;
            this.primaryAttributes.intelligence = this.primaryAttributes.intelligence + 3;
            this.primaryAttributes.agility = this.primaryAttributes.agility + 2;
            this.primaryAttributes.vitality = this.primaryAttributes.vitality + 2;
            this.UpdateStatus();
            this.UpdateTotalHealMana();
            this.healPoints = this.healPointsTotal;
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