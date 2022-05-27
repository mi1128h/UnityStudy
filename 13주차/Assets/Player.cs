using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpHeight = 5f;
    public float speed;
    public Transform footPosition;
    public LayerMask groundLayer;
    
    private Rigidbody2D _rigidbody;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    
    private Vector2 _playerInput;
    private bool _isGround;
    
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

        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpHeight);
        }
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_playerInput.x * Time.fixedDeltaTime * speed, _rigidbody.velocity.y);
        _animator.SetFloat("move_speed", Mathf.Abs(_rigidbody.velocity.x));

        var hit2D = Physics2D.BoxCast(footPosition.position, new Vector2(0.1f, 0.05f), 0f, Vector2.down, 0, groundLayer);
        _isGround = hit2D.collider != null;
    }
}
