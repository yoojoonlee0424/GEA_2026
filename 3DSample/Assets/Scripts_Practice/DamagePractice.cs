using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack, defense;
    public bool isCritical, targetlsBoss;

    [ContextMenu("데미지")]

    void Calc()
    {
        int defDamage = (attack - defense) < 1 ? 1 : (attack - defense);
        
        if(isCritical)
        {
            defDamage = defDamage * 2; 
        }
        if(targetlsBoss)
        {
            defDamage = defDamage / 2;
        }

        Debug.Log(defDamage);
    }


}
