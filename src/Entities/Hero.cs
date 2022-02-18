namespace projeto_rpg.src.Entities
{
    public abstract class Hero
    {
        public string name;
        public int level;
        public string heroeType;
        public int healPointsTotal;
        public int healPoints;
        public int manaPointsTotal;
        public int manaPoints;

        public Hero(string name, int level, string heroeType)
        {
            this.name = name;
            this.level = level;
            this.heroeType = heroeType;
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
            return this.name + " realizou um ataque.";
        }
    }
}