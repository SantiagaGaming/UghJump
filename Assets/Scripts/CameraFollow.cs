using UnityEngine;

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

   [SerializeField] private GameObject _player;
    private float _cameraMoveSpeed = 3;

    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x -1, _player.transform.position.x, Time.deltaTime * _cameraMoveSpeed),
                                               Mathf.Lerp(transform.position.y, _player.transform.position.y, Time.deltaTime * _cameraMoveSpeed), 0);
    }
}
