using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.2f;


    [ContextMenu("정산")]
    void com()
    {
        int PlayHour = (playSeconds / 3600);
        int PlayMinute = ((playSeconds / 60) - (PlayHour * 60));
        int PlaySeconds = (playSeconds % 60);

        Debug.Log("플레이 시간" + " : " + PlayHour + " : " + PlayMinute + " : " + PlaySeconds);

        Debug.Log("1인당 : " + (gold / members) + "리더 보너스 : " + (gold % members));

        int DefExp = kills * expPerKill;
        int exp = (int)((float)DefExp * expRate);
        Debug.Log("경험치 : " + exp + " (기본 " + DefExp +" )");

        int Level = 1 + (exp / 100);
        int LevelRemain = 100 - (exp % 100);
        Debug.Log("LV : " + Level + " (다음 레벨까지 " + LevelRemain + " )");

        Debug.Log("평균 데미지 : " + (float)totalDamage / hits);
    }
}
