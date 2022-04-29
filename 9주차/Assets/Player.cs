using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.coin++;
            var itemDatas = GameManager.Instance.ItemDatabase.ItemDatas;

            foreach (var itemData in itemDatas)
            {
                print($"{itemData.itemName}: LV.{itemData.itemLevel}");
            }
        }
    }
}
