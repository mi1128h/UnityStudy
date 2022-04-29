using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0, fileName = "Item Database", menuName = "Study/Item/Create Item DB")]
public class ItemDatabase : ScriptableObject
{
    public ItemData[] ItemDatas;
}

[Serializable]
public class ItemData
{
    public string itemName;
    public int itemLevel;
    public float itemDefaultDur;
    public Sprite itemThumbnail;
}

[Serializable]
public class SwordData
{
    public string itemName;
    public int itemLevel;
    public float attackPower;
}