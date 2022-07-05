using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMover : MonoBehaviour
{
    public UnityAction RightMove;
    public UnityAction LeftMove;
    private float _moveSpeed;
    private Vector3 _side;
    private void Start()
    {
        _side = Vector3.forward;
    }
    private void Update()
    {
        transform.position += _side * _moveSpeed * Time.deltaTime;
    }
    public void MoveRight()
    {
        _moveSpeed = -5;
        RightMove?.Invoke();
    }
    public void MoveLeft()
    {
        _moveSpeed = 5;
        LeftMove?.Invoke();
    }
    public void Idle()
    {
        _moveSpeed = 0;
    }
}
