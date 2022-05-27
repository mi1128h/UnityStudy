using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class Ai : MonoBehaviour
{
    public Transform target;

    private IAstarAI _ai;
    
    // Start is called before the first frame update
    void Start()
    {
        _ai = GetComponent<AILerp>();
    }

    // Update is called once per frame
    void Update()
    {
        _ai.destination = target.position;
    }
}
