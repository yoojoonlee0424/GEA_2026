using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    List<int> criticals = new List<int>();

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int totaldmg = 0;
        int maxdmg = damages.Length == 0 ? 0 : damages[0];
        int maxindex = 1;

        criticals.Clear();

        foreach (int damage in damages)
        {
            totaldmg += damage;
            if(damage >= criticalLine)
            {
                criticals.Add(damage);
            }
        }
        Debug.LogError("----- 배틀 로그 -----");
        Debug.Log("총 데미지 : " + totaldmg);
        Debug.Log("치명타 : " + criticals.Count + "회");

        string list = "";
        foreach(int c in criticals)
        {
            list += "," + c;
        }

        if(criticals.Count != 0)
        {
            Debug.Log("치명타 목록 : " + list);
        }
        else
        {
            Debug.Log("치명타 목록 : 없음");
        }

        foreach(int m in criticals)
        {
            
            if (m > maxdmg)
            {
                maxdmg = m;
                
            }
        }
        foreach (int num in damages)
        {
            if (num == maxdmg)
            {
                break;
            }
            maxindex++;
        }

        string r = "최고 데미지 : " + maxdmg;

        if (damages.Length != 0)
        {
            r += " (" + maxindex + " 번째 공격)";
        }
        else
        {
            r += " (기록 없음)";
        }


        Debug.Log(r);

        Debug.LogError("----- ------- -----");
    }
}
