using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.2f;


    [ContextMenu("정산")]
    void com()
    {

        Debug.LogError(" -------- 총 스텟 -------- ");

        int PlayHour = (playSeconds / 3600);
        int PlayMinute = (playSeconds / 60);
        int PlayMinute1 = ((PlayMinute % 60)/10);
        int PlayMinute2 = (((PlayMinute % 60)) - (PlayMinute1 * 10));
        int PlaySeconds1 = ((playSeconds % 60)/10);
        int PlaySeconds2 = ((playSeconds % 60) - (PlaySeconds1 * 10));

        Debug.Log("플레이 시간   " + PlayHour + " : " + PlayMinute1 + PlayMinute2 + " : " + PlaySeconds1 + PlaySeconds2);

        Debug.Log("1인당 : " + (gold / members) + "G ," + "리더 보너스 : " + (gold % members) + "G");

        int DefExp = kills * expPerKill;
        int exp = (int)((float)DefExp * expRate);
        Debug.Log("경험치 : " + exp + " (기본 " + DefExp +" )");

        int Level = 1 + (exp / 100);
        int LevelRemain = 100 - (exp % 100);
        Debug.Log("LV : " + Level + ", (다음 레벨까지 " + LevelRemain + " )");

        Debug.Log("평균 데미지 : " + (float)totalDamage / hits);

        Debug.LogError(" -------- ----- -------- ");
    }
}
