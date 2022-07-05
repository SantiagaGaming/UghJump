using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y - 0.5f, _player.transform.position.z);
    }
}
