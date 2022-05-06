using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTextUi : MonoBehaviour
{
    private void Start()
    {
        EventManager.Instance.Subscribe("game_over", param =>
        {
            gameObject.SetActive(true);
        });
        
        gameObject.SetActive(false);
    }
}
