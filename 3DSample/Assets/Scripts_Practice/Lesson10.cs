using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    public int height = 3;


    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);
        Debug.Log(isDead && !hasShield);
        Debug.Log(isDead || hasShield);
        Debug.Log(!(hp > 0) == isDead);
    }

    [ContextMenu("쇼트 서킷")]
    void ShortCircuit()
    {
        int total = 100;
        int count = 0;
        if (count != 0 && total / count > 5)
        {
            Debug.Log("평균 5 초과");
        }
        if (count == 0 || total / count > 5)
        {
            Debug.Log("통과");
        }
        bool wrong = total / count > 5 && count != 0;
    }

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;

        Debug.Log(canAttack);
        Debug.Log(isDanger);

    }


    [ContextMenu("NPC")]

    void Swtich()
    {
        string value = "플레이어";

        switch (value)
        {
            case "NPC":
            case "플레이어":
                Debug.Log("우호적");
                break;

            case "몬스터":
                Debug.Log("적대적");
                break;

        }
    }

    [ContextMenu("격자")]
    void Grid()
    {
        string text = "";
        for (int row = 1; row <= 7; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                text += row + "-" + col + " ";
            }
            text += "\n";
        }
        Debug.Log(text);
    }


    [ContextMenu("계단")]

    void Stair()
    {

        string stair = "";

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                stair += "*";
            }
            stair += "\n";
        }

        Debug.Log(stair);
    }

    [ContextMenu("반전 계단")]

    void ReStair()
    {

        string stair = "";

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < height - i; j++)
            {
                stair += "*";
            }
            stair += "\n";
        }

        Debug.Log(stair);
    }

    [ContextMenu("오른쪽 계단")]

    void RightStair()
    {

        string stair = "";

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= height - i; j++)
            {
                stair += " ";
            }
            for (int k = 0; k <= i; k++)
            {
                stair += "*";
            }
            stair += "\n";
        }

        Debug.Log(stair);
    }

    [ContextMenu("트리 계단")]

    void Tree()
    {

        string stair = "";

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= height - i; j++)
            {
                stair += " ";
            }
            for (int k = 0; k <= i * 2; k++)
            {
                stair += "*";
            }
            stair += "\n";
        }

        Debug.Log(stair);
    }


    [ContextMenu("반복")]
    void Loop()
    {
        int sum = 0;
        for (int i = 2; i <= 10; i+=2)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    [ContextMenu("예측 6")]
    void Predict6()
    {
        int i = 5;
        int a = i++;
        int b = ++i;
        Debug.Log(a + " " + b + " " + i);
    }
}
