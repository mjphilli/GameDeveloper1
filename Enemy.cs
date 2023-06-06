class Enemy
{
    public string Name;
    private int Health;
    public int _Health
    {
        get { return Health; }
    }
    public List<Attack> AttackList;

    public Enemy(string name, int health = 100)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }

    public Attack RandomAttack()
    {
        Random rand = new Random();
        return AttackList[rand.Next(AttackList.Count)];
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }
}