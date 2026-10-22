using UnityEngine;
using TMPro;
using System;

public class KillCountUI : MonoBehaviour
{
    public TMP_Text label;
    public TMP_Text time_label;
    void Start()
    {
        Health.KillCount = 0;   // Play 마다 0 부터
    }

    void Update()
    {
        float time_float;
        int time;
        time_float = Time.timeSinceLevelLoad;
        label.text = "KILL " + Health.KillCount;
        time = Mathf.RoundToInt(time_float);
        time_label.text = "Time : " + time;
    }
}
