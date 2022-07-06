using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Legs legs))
            ColliderChanger(false);
        if (other.TryGetComponent(out Head head))
            ColliderChanger(true);
        if (other.TryGetComponent(out EndCollider end))
            gameObject.SetActive(false);
    }
    protected virtual void ColliderChanger(bool value)
    {
        GetComponent<Collider>().isTrigger = value;
    }

}
