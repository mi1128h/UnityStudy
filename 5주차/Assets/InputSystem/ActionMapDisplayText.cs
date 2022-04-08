using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionMapDisplayText : MonoBehaviour
{
    public PlayerInput playerInput;
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }
    
    // Update is called once per frame
    void Update()
    {
        _text.text = playerInput.currentActionMap.name;
    }
}
