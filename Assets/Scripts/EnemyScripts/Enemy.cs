public class Enemy : Attributes, IEnemy
{
    public float moveSpeed;
    
    public void moveSpeedCalculate()
    {
        moveSpeed = agility * 0.25f;
    }
}
