using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float speed = 2f;
    private float _timer = 1f;
    private bool _canGo = true;
    void Start()
    {
        gameObject.transform.position = new Vector3(transform.position.x, _startPoint.position.y, _startPoint.position.z);
    }


    void Update()
    {
        if (_canGo)
            transform.position = Vector3.MoveTowards(transform.position, _startPoint.position, speed * Time.deltaTime);
        if (transform.position == _startPoint.position)
        {
            Transform temp = _startPoint;
            _startPoint = _endPoint;
            _endPoint = temp;
            _canGo = false;
            StartCoroutine(Waiting());
        }

    }
   private IEnumerator Waiting()
    {
        yield return new WaitForSeconds(_timer);
        _canGo = true;
    }
}
