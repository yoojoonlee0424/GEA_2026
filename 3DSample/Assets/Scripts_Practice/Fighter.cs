using Unity.VisualScripting.Antlr3.Runtime;

public class Fighter 
{
    string name;
    int hp;
    int attack;
    int defense;

    public Fighter(string name, int hp, int attack, int defense)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
    }

    public int GetDamageTo(Fighter target)
    {
        int damage;
        damage = attack - defense;
        return damage;   // 2. 지우고 작성
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            hp = 0;
        }
    }

    public bool IsDead()
    {
        if(hp <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
