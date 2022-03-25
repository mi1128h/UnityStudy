using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    public abstract void Cry();
    
    void Start()
    {
        //print("크오아아앙!");
        Cry();
    }
    
    void Update()
    {
        
    }
}
