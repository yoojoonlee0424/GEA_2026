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
        int maxdmg;
        int maxindex = 0;

        criticals.Clear();

        foreach (int damage in damages)
        {
            totaldmg += damage;
            if(damage >= criticalLine)
            {
                criticals.Add(damage);
            }
        }
        Debug.Log("총 데미지 : " + totaldmg);
        Debug.Log("치명타 : " + criticals.Count + "회");

        string list = "";
        foreach(int c in criticals)
        {
            list += "," + c;
        }
        foreach(int m in criticals)
        {
            maxindex++;
            if (m >= criticals[maxindex])
            {
                criticals[m] = criticals[maxindex];
            }
        }
        Debug.Log("치명타 목록 : " + list);
        Debug.Log(criticals[1]);

    }
}
