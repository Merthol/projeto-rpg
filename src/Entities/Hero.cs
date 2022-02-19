namespace projeto_rpg.src.Entities
{
    public class Hero
    {
        protected string name;
        protected int level;
        protected string heroeType;
        protected int healPointsTotal;
        protected int healPoints;
        protected int manaPointsTotal;
        protected int manaPoints;
        protected PrimaryAttributes primaryAttributes;
        protected SecondaryAttributes secondaryAttributes;

        public Hero(string name, string heroeType)
        {
            this.name = name;
            this.level = 1;
            this.heroeType = heroeType;
        }

        protected struct PrimaryAttributes
        {
            public int strength;
            public int intelligence;
            public int agility;
            public int vitality;
        }

        protected struct SecondaryAttributes
        {
            public double attack;
            public double magicalAttack;
            public double defense;
            public double magicalDefence;
            public double attackSpeed;
        }

        protected void UpdateStatus()
        {
            secondaryAttributes.attack = primaryAttributes.strength * 3;
            secondaryAttributes.magicalAttack = primaryAttributes.intelligence * 3;
            secondaryAttributes.defense = primaryAttributes.strength * 2;
            secondaryAttributes.magicalDefence = primaryAttributes.intelligence * 2;
            secondaryAttributes.attackSpeed = primaryAttributes.agility * 0.03;
        }

        protected virtual void UpdateTotalHealMana()
        {

        }

        public virtual void LevelUp(int up)
        {

        }

        public override string ToString()
        {
            string exibition = $"{this.name}\nLvl: {this.level}\t{this.heroeType}\n";
            exibition = exibition + $"HP\t{this.healPoints}/{this.healPointsTotal}\n";
            exibition = exibition + $"MP\t{this.manaPoints}/{this.manaPointsTotal}";
            return exibition;
        }

        public virtual string Attack()
        {
            return "";
        }

        public string displayPrimaryAttributes()
        {
            string exibition;
            exibition = $"Força:\t\t{this.primaryAttributes.strength}\n";
            exibition = exibition + $"Inteligência:\t{this.primaryAttributes.intelligence}\n";
            exibition = exibition + $"Agilidade:\t{this.primaryAttributes.agility}\n";
            exibition = exibition + $"Vitalidade:\t{this.primaryAttributes.vitality}";

            return exibition;
        }

        public string displaySecondaryAttributes()
        {
            string exibition;
            exibition = $"Ataque:\t\t{this.secondaryAttributes.attack}\n";
            exibition = exibition + $"Ataque Mágico:\t{this.secondaryAttributes.magicalAttack}\n";
            exibition = exibition + $"Defesa:\t\t{this.secondaryAttributes.defense}\n";
            exibition = exibition + $"Defesa mágica:\t{this.secondaryAttributes.magicalDefence}\n";
            exibition = exibition + $"Veloc. ataque:\t{Math.Round(this.secondaryAttributes.attackSpeed, 2)}";

            return exibition;
        }

    }
}