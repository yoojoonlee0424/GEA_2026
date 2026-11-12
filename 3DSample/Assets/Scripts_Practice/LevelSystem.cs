using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;


    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1; 
        int exp = 0;

        for(int i = 1; i <= killCount; i++)
        {
            exp += expPerKill;

            while(exp >= level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log(level + " " + i);
            }
        }

        int levelToExp = (level * 10000);

        Debug.Log("최종 LV : " + level + "경험치 " + exp + "/" + levelToExp);
    }
}
