namespace projeto_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, string heroeType) : base(name, heroeType)
        {
            this.primaryAttributes.strength = 3;
            this.primaryAttributes.intelligence = 3;
            this.primaryAttributes.agility = 6;
            this.primaryAttributes.vitality = 3;
            this.UpdateStatus();
            this.UpdateTotalHealMana();
            this.healPoints = this.healPointsTotal;
            this.manaPoints = this.manaPointsTotal;
        }

        protected override void UpdateTotalHealMana()
        {
            this.healPointsTotal = 100 + (level * 13) + this.primaryAttributes.vitality * 3;
            this.manaPointsTotal = 30 + (level * 12) + this.primaryAttributes.intelligence * 4;
        }

        public virtual void LevelUp()
        {
            this.level++;
            this.primaryAttributes.strength = this.primaryAttributes.strength + 2;
            this.primaryAttributes.intelligence = this.primaryAttributes.intelligence + 2;
            this.primaryAttributes.agility = this.primaryAttributes.agility + 4;
            this.primaryAttributes.vitality = this.primaryAttributes.vitality + 3;
            this.UpdateStatus();
            this.UpdateTotalHealMana();
            this.healPoints = this.healPointsTotal;
            this.manaPoints = this.manaPointsTotal;
        }

        public override string Attack()
        {
            return this.name + " lançou um shuriken.";
        }
    }
}