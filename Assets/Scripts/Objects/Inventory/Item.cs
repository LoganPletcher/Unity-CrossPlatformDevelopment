using System;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    protected string Name;
    protected int Weight;
    protected bool Stackable = false;
    protected int StackMax;
}

public class Potion : Item
{
    protected int Strength;
}

