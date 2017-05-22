using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[CreateAssetMenu()]
public class LootTable : ScriptableObject
{
    [System.Serializable]
    public class Loot
    {
        public Item Item;

        [Range(0, 100)]
        public int Percentage;
    }

    public List<Loot> LootList = new List<Loot>();

    public virtual bool DropOnlyOne
    {
        get { return true; }
    }

    public virtual void Initialize()
    {
        
    }
    
    public virtual void DropLoot()
    {
        List<Loot> lootPool = new List<Loot>();
        foreach (Loot loot in LootList)
        {
            for (int i = 0; i < loot.Percentage; i++)
            {
                lootPool.Add(loot);
            }
        }
        Loot droppedLoot = lootPool[Random.Range(0, lootPool.Count)];
        Debug.Log(droppedLoot.Item.name);
    }

}

#if UNITY_EDITOR

[CustomEditor(typeof(LootTable))]
public class LootTableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var mytarget = (LootTable)target;

        if (GUILayout.Button("Drop Loot"))
            mytarget.DropLoot();
    }
}

#endif