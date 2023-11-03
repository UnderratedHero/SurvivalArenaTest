using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private PlayerInput _input;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody.velocity = _input.MoveDirection * _config.MoveSpeed;
    }
}
