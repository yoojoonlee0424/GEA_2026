using UnityEngine;

public class Battle : MonoBehaviour
{
    public int heroHp = 100;
    public int heroAttack = 30;
    public int heroDefense = 10;
    public int monsterHp = 80;
    public int monsterAttack = 25;
    public int monsterDefense = 5;



    void Attack(int _turn, Fighter attacker, Fighter target)
    {
        _turn++;
        attacker.GetDamageTo(target);
        target.TakeDamage(attacker.GetDamageTo(target));
    }

    [ContextMenu("전투")]
    void StartBattle()
    {
        int turn = 0;

        Fighter Hero = new Fighter("용사", heroHp, heroAttack, heroDefense);
        Fighter Monster = new Fighter("슬라임", monsterHp, monsterAttack, monsterDefense);

        Attack(turn, Hero, Monster);
        Monster.IsDead();
        Attack(turn, Monster, Hero);
        Hero.IsDead();
        //for문안에 
        //while ()
    }
}
