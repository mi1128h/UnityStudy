using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rigidbody;
    private Vector2 _playerInput;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (_rigidbody.velocity.x > 0) _spriteRenderer.flipX = false;
        else if (_rigidbody.velocity.x < 0) _spriteRenderer.flipX = true;
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_playerInput.x * Time.fixedDeltaTime * speed, _rigidbody.velocity.y);
        _animator.SetFloat("move_speed", Mathf.Abs(_rigidbody.velocity.x));
    }
}
