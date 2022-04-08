using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleActionMap : MonoBehaviour
{
    public PlayerInput PlayerInput;

    public void ToggleMap()
    {
        if(PlayerInput.currentActionMap.name == "Game")
            PlayerInput.SwitchCurrentActionMap("UI");
        else
            PlayerInput.SwitchCurrentActionMap("Game");
    }
}
