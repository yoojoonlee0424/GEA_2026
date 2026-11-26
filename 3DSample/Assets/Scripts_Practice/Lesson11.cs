using UnityEngine;
using System.Collections.Generic;

public class Lesson11 : MonoBehaviour
{

    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int num = 0;
        int sum = 0;
        foreach(int i in monsterHps)
        {
            if(i > 0 )
            {
                num++;
                sum += i;
            }
        }

        Debug.Log("살아 있는 몬스터 : " + num);
        Debug.Log("남은 몬스터 체력 합 : " + sum);
    }


}
