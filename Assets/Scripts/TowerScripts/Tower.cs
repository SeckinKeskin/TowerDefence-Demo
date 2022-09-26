public class Tower : Attributes, ITower
{
    public float attackRange;
    public float attackSpeed;
    public float damage;

    public void attackRangeCalculate()
    {
        attackRange = intelligence * 0.25f;
    }

    public void attackSpeedCalculate()
    {
        attackSpeed = agility;
    }

    public void damageCalculate()
    {
        damage = agility * strength;
    }
}
