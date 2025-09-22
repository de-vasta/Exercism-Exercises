abstract class Character
{
    public abstract int DamagePoints(Character target);
    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {this.GetType()}";
}

class Warrior : Character
{
    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    bool spellPrepared = false;
    public override bool Vulnerable() => !spellPrepared;
    public override int DamagePoints(Character target) => spellPrepared ? 12 : 3;
    public void PrepareSpell() => spellPrepared = true;

}