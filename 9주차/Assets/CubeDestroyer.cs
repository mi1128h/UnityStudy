using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeDestroyer : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke(nameof(Hide), Random.Range(1f, 3f));
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
