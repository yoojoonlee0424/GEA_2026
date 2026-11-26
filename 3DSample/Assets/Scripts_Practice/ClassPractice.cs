using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    Weapon OldWeapon = new Weapon("낡은 검", 2);

    [ContextMenu("클래스 실습")]
    void ShowWeapon()
    {
        for(int i = 0; i < 3; i++)
        {

            if(OldWeapon.Use() == true)
            {
                Debug.Log(OldWeapon.Getname() + " 사용, " + "남은 내구도 : " + OldWeapon.GetDur());
            }
            else
            {
                Debug.Log(OldWeapon.Getname() + " 사용, " + "낡은 검 부서짐 ");
            }
        }
    }
}
