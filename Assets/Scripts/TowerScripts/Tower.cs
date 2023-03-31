public class Tower : ITower
{
    public Attributes attributes;
    public float attackRange;
    public float attackSpeed;
    public float damage;

    public Tower(Attributes _attributes)
    {
        attributes = _attributes;
    }

    public void attackRangeCalculate()
    {
        attackRange = attributes.intelligence * 0.25f;
    }

    public void attackSpeedCalculate()
    {
        attackSpeed = attributes.agility;
    }

    public void damageCalculate()
    {
        damage = attributes.agility * attributes.strength;
    }
}
