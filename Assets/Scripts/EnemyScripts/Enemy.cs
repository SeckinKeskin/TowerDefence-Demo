public class Enemy : IEnemy
{
    public float moveSpeed;
    public Attributes attributes = new Attributes();

    public void moveSpeedCalculate()
    {
        moveSpeed = attributes.agility * 0.25f;
    }
}
