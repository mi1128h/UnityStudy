using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string eventName;
    
    public void Start()
    {
        EventManager.Instance.Subscribe(eventName, OnEvent);
    }

    private void OnEvent(object param)
    {
        print($"{gameObject.name}: {eventName}이 발동되었고 파라미터는: {param}");
    }
}
