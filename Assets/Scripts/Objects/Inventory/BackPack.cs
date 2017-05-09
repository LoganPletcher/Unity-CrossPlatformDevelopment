using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour
{
    public int Capacity = 25;

    [SerializeField] private List<Item> inspectorItems;

    public List<Item> Items = new List<Item>();

    private void Start()
    {
        
    }

    public bool Add(Item item)
    {
        if (Items.Count < Capacity)
            Items.Add(item);

        return false;
    }

    public bool Remove(Item item)
    {
        if (Items.Contains(item))
            Items.Remove(item);
        return false;
    }

}