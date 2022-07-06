using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out EndCollider end))
         {
            GameManager manager = FindObjectOfType<GameManager>();
            manager.EndGame(false);
        }
    }
}
