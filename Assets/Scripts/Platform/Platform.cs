using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Legs legs))
            ColliderChanger();
    }
    protected virtual void ColliderChanger()
    {
        GetComponent<Collider>().isTrigger = false;
    }

}
