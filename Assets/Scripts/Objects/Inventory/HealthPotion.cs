using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion/Health Potion")]
public class HealthPotion : Potion
{
    public string pName
    {
        get
        {
            return Name;
        }
    }

    public int pWeight
    {
        get
        {
            return Weight;
        }
    }

    public bool pStackable
    {
        get
        {
            return Stackable;
        }
    }

    public int pStackMax
    {
        get
        {
            return StackMax;
        }
    }

    public int hp
    {
        get
        {
            return Strength;
        }
    }

    public HealthPotion()
    {
        Name = "Health Potion";
        Weight = 2;
        Stackable = true;
        StackMax = 20;
        Strength = 10;
    }

    public HealthPotion(string name)
    {
        Name = name;
        Weight = 2;
        Stackable = true;
        StackMax = 20;
        Strength = 10;
    }

    public HealthPotion(string HealthPotionName, int HealthPotionRestorationPoints)
    {
        Name = HealthPotionName;
        Strength = HealthPotionRestorationPoints;
    }
    
    public HealthPotion(params object[] Element)
    {
        for(int i = 0; i < Element.Length; i++)
        {
            if (Element[i].GetType() == typeof(string))
            {
                Name = (string)Element[i];
            }

            //else if (Element[i].GetType() == typeof(int))

        }
    }

    public void Use()
    {
        
    }
}

public class Program
{
    int main()
    {
        HealthPotion gHP = new HealthPotion("Greater Potion of Healing", 5, true, 15, 25);
        gHP.Use();

        return 0;
    }
}