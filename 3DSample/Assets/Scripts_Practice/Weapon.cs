using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Weapon
{
    private string name; 
    private int durability;

    public Weapon(string name, int durability)
    {
        this.name = name;
        this.durability = durability;
    }


    public bool Use()
    {
        if(durability <= 0)
        {
            return false;
        }
        else
        {
            durability--;
            return true;
        }
    }

    public string Getname()
    {
        return name;
    }
    public int GetDur()
    {
        return durability;
    }

}
