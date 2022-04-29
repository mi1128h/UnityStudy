using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.coin++;
            var itemDatas = GameManager.Instance.ItemDatabase.ItemDatas;

            //-------------------------------------------------
            // Where
            
            // var itemsLowerThan3 =
            //     from item in itemDatas
            //     where item.itemLevel < 3
            //     select item.itemName;
            //
            // var itemsLowerThan3 =
            //     itemDatas
            //         .Where(item => item.itemLevel < 3)
            //         .Select(item => item.itemName);
            //
            // foreach (var itemName in itemsLowerThan3)
            // {
            //     print(itemName);
            // }
            
            //-------------------------------------------------
            // Any
            
            // if (itemDatas.Any(item => item.itemLevel > 20))
            // {
            //     print("20이 넘는 아이템이 있군요~~~");
            // }

            //-------------------------------------------------
            // FirstOrDefault
            
            //var sword1 = itemDatas.FirstOrDefault(item => item.itemName == "Sword1");
            // if (sword1 != null)
            //     print($"{sword1.itemName} : Lv.{sword1.itemLevel}");
            // else
            //     print("그런 아이템은 없는디요..");
            
            //-------------------------------------------------
            // OrderBy
            
            // var itemDatasOrderedByLevel = itemDatas.OrderBy(item => item.itemLevel);
            // foreach (var itemData in itemDatasOrderedByLevel)
            // {
            //     print(itemData.itemName);
            // }
            
            //-------------------------------------------------
            // Aggregate

            // var itemNames = itemDatas
            //     .Select(item => item.itemName)
            //     // .Aggregate((before, after) =>
            //     // {
            //     //     return before + ", " + after;
            //     // });
            //     .Aggregate((before, after) => before + ", " + after);
            //
            // print(itemNames); 
            
            //-------------------------------------------------
            // Select

            var swordDatas = itemDatas
                .Where(item => item.itemName.Contains("Sword"))
                .Select(item => new SwordData
                {
                    itemName = item.itemName,
                    itemLevel = item.itemLevel,
                    attackPower = item.itemLevel * 10
                });
            
            foreach (var swordData in swordDatas)
            {
                print($"{swordData.itemName}'s Power: {swordData.attackPower}");
            }
        }
    }
}
