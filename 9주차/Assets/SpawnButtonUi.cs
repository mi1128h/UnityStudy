using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtonUi : MonoBehaviour
{
    public ObjectPoolingManager poolingManager; // singleton 으로 만들면 좋겠다
    
    public void Spawn(string objectName)
    {
        var position = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        );

        var rotation = new Vector3(
            Random.Range(-180f, 180f),
            Random.Range(-180f, 180f),
            Random.Range(-180f, 180f)
        );
        
        poolingManager.Get(objectName, position, Quaternion.Euler(rotation));
    }
}
