using System;
using UnityEngine;

public class Player: MonoBehaviour
{
    Vector2 _moveDirection;
    private Rigidbody _playerPhysics;
    [SerializeField]  private float moveSpeed = 5;

    private void Awake()
    {
        _playerPhysics = GetComponent<Rigidbody>();
        PlayerControls.Initialize(this);
        PlayerControls.PlayMode();
    }

    void Move()
    {
        
    }

    void Jump()
    {
        
    }

    void Crouch()
    {

    }

    public void SetMoveDirection(Vector2 readValue)
    {
        _moveDirection = readValue;
    }

    private void Update()
    {
        _playerPhysics.AddForce(_moveDirection*moveSpeed, ForceMode.Force);
    }
}
