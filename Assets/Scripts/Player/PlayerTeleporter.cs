using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    [SerializeField] private Transform _leftPos;    
    [SerializeField] private Transform _rightPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="LeftWall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _leftPos.transform.position.z);
        }
        if (other.tag == "RightWall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _rightPos.transform.position.z);
        }
    }
}
