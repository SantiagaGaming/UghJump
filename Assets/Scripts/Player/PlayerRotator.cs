using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerMover))]
public class PlayerRotator : MonoBehaviour
{
    [SerializeField] private GameObject _body;
    private PlayerMover _playerMover;
    private void Awake()
    {
        _playerMover = GetComponent<PlayerMover>();
    }
    private void OnEnable()
    {
        _playerMover.RightMove += OnRotateRight;
        _playerMover.LeftMove += OnRotateLeft;
    }
    private void OnDisable()
    {
        _playerMover.RightMove -= OnRotateRight;
        _playerMover.LeftMove -= OnRotateLeft;
    }
    private void OnRotateRight()
    {
        _body.transform.localRotation = Quaternion.Euler(-90, 180, 0);
    }

    private void OnRotateLeft()
    {
        _body.transform.localRotation = Quaternion.Euler(-90, 0, 0);

    }
}
