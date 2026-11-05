using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHP, maxHP;


    [ContextMenu("체력")]

    void PrintHp()
    {
        float HP = ((float)currentHP / maxHP) * 100;
        if(currentHP <= maxHP)
        {
            Debug.Log("HP : " + ((int)HP) + "%");
        }
        else
        {
            Debug.Log("최대 체력 초과");
        }

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
