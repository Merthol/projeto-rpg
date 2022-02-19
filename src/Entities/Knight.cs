namespace projeto_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, string heroeType) : base(name, heroeType)
        {
            this.primaryAttributes.strength = 5;
            this.primaryAttributes.intelligence = 1;
            this.primaryAttributes.agility = 3;
            this.primaryAttributes.vitality = 6;
            this.UpdateStatus();
            this.UpdateTotalHealMana();
            this.healPoints = this.healPointsTotal;
            this.manaPoints = this.manaPointsTotal;
        }

        protected override void UpdateTotalHealMana()
        {
            this.healPointsTotal = 110 + (level * 15) + this.primaryAttributes.vitality * 3;
            this.manaPointsTotal = 30 + (level * 5) + this.primaryAttributes.intelligence * 4;
        }

        public virtual void LevelUp()
        {
            this.level++;
            this.primaryAttributes.strength = this.primaryAttributes.strength + 4;
            this.primaryAttributes.intelligence = this.primaryAttributes.intelligence + 1;
            this.primaryAttributes.agility = this.primaryAttributes.agility + 2;
            this.primaryAttributes.vitality = this.primaryAttributes.vitality + 4;
            this.UpdateStatus();
            this.UpdateTotalHealMana();
            this.healPoints = this.healPointsTotal;
            this.manaPoints = this.manaPointsTotal;
        }

        public override string Attack()
        {
            return this.name + " atacou com sua espada.";
        }
    }
}