using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBall : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    public void OnMove(InputValue value)
    {
        //print(value.Get<Vector2>());
        var rawValue = value.Get<Vector2>();
        _direction = new Vector3(rawValue.x, 0, rawValue.y);
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_direction);
    }
}
