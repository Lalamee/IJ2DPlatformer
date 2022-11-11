using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedRun;
    [SerializeField] private float _forceJump;

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _renderer;
    private Animator _animator;
    private bool _isGround;
    private string _currentAnimation;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void ChangeAnimation(string animation)
    {
        if (_currentAnimation == animation) 
            return;

        _animator.SetBool(_currentAnimation,false);
        _animator.SetBool(animation, true);
        _currentAnimation = animation;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            _isGround = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            _isGround = false;
        }
    }

    private void Move()
    {
        if (_rigidbody2D.velocity.magnitude == 0.0f)
            ChangeAnimation("Idle");

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speedRun * Time.deltaTime,0,0 );
            _renderer.flipX = false;
            ChangeAnimation("Run");
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speedRun * Time.deltaTime * -1,0,0 );
            _renderer.flipX = true;
            ChangeAnimation("Run");
        }

        if (Input.GetKeyDown(KeyCode.W) && _isGround)
            _rigidbody2D.AddForce(Vector2.up * _forceJump);
    }
}
