using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    public int score;

    string GetGrade(int score)
    {
        if(score >= 90)
        {
            return "A";
        }
        else if(score >= 70)
        {
            return "B";
        }
        else
        {
            return "C";
        }
    }

    [ContextMenu("함수 실습")]
    void ShowGrades()
    {
        Debug.Log(score + " 점 : " + GetGrade(score));
    }
}
