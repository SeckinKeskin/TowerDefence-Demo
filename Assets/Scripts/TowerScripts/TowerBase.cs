public class Tower
{
    private ElementalTypes _towerElemental = ElementalTypes.None;
    private float _attackRange = 0.0f;
    private float _attackSpeed = 0.0f;
    private float _damage = 0.0f;
    private float _elementalEffect = 0.0f;
    private int _agility = 0;
    private int _strength = 0;
    private int _intelligence = 0;

    public ElementalTypes towerElemental
    {
        get => _towerElemental;
        set => _towerElemental = value;
    }

    public int agility
    {
        get => _agility;
        set => _agility = value;
    }

    public int strength
    {
        get => _strength;
        set => _strength = value;
    }

    public int intelligence
    {
        get => _intelligence;
        set => _intelligence = value;
    }

    public float attackRange
    {
        get => _attackRange;
        set => _attackRange = value;
    }

    public float attackSpeed
    {
        get => _attackSpeed;
        set => _attackSpeed = value;
    }

    public float damage
    {
        get => _damage;
        set => _damage = value;
    }

    public float elementalEffect
    {
        get => _elementalEffect;
        set => _elementalEffect = value;
    }
}