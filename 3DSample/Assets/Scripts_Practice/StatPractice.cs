using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName;
    public int level;
    public float attack;
    public bool isBoss;


    [ContextMenu("ShowStat")]

    void Stat()
    {
        Debug.Log("이름 :" + playerName);
        Debug.Log("레벨 :" + level);
        Debug.Log("공격력 :" + attack);
        Debug.Log("보스임? :" + isBoss);
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
