using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Ball))]
public class Ball : MonoBehaviour
{
    void Start()
    {
#if UNITY_EDITOR
        transform.localScale = Vector3.one;
#else
        transform.localScale = Vector3.one * 10f;
#endif

#if TEST
        Debug.Log("Hello world");
#endif
    }
}
