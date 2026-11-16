using Unity.Burst.Intrinsics;
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
        int sum = 0;

        Debug.LogWarning("----- 레벨 정산 -----");

        for (int i = 1; i <= killCount; i++)
        {
            exp += expPerKill;
            sum += expPerKill;

            while(exp >= level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log("레벨업! LV : " + level + " " + "(" + i + " 마리째)");
            }
        }

        string stair = "";

        int levelToExp = (level * 10000);
        int barLength =((exp * 10) / levelToExp);

        for (int j = 0; j < barLength; j++)
        {
            stair += "■";
        }
        for (int k = 0; k < 10 -barLength; k++)
        {
            stair += "□";
        }

        Debug.Log("최종 LV: " + level + " " + stair + " " + exp + " / " + levelToExp);

        if (expPerKill > 0)
        {
            int levelupMonster = ((levelToExp  - exp) / expPerKill);

            int levelupMonsterRe = levelupMonster > 1 ? levelupMonster : levelupMonster + 1;

            Debug.Log("마지막 몬스터를 " + levelupMonsterRe + " 마리 더 잡으면 레벨업!!" );
        }

        /*
        int commaSum = 0;
        int commaRest = 0;
        string Comma = "";

        int Tmp = 1;

        while( Tmp < 4)
        {
            commaSum = (int)(sum / Mathf.Pow(1000, Tmp));
            commaRest = (int)(sum % Mathf.Pow(1000, Tmp));
            Comma += commaSum;
            Comma += ",0"; // 0  더 추가 생각해보기
            Comma += commaRest;

            Tmp++;
        }

        Debug.Log("얻은 경험치 합계 : " + Comma + "    " + commaSum +"    " + commaRest + "    " + sum);*/

        Debug.Log("얻은 경험치 합계 : " + sum);

        Debug.LogWarning("----- -------- -----");
    }
}
