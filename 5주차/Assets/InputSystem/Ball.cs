using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");
        //print($"horizontal: {hor}");
        
        _direction = new Vector3(hor, 0, ver);

        //transform.Translate(_direction);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _direction += new Vector3(0, 500f, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //print($"Mouse Button Down: {Input.mousePosition}");
            var pos = Input.mousePosition;
            var cam = FindObjectOfType<Camera>();
            var ray = cam.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out var hitInfo))
            {
                print(hitInfo.collider.name);
            }
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_direction);
    }
    
}
