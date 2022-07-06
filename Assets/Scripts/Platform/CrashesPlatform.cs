using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashesPlatform : Platform
{
    [SerializeField] private GameObject[] _platforms;

    protected override void ColliderChanger(bool value)
    {
        foreach (var item in _platforms)
        {
            Rigidbody rb = item.GetComponent<Rigidbody>();
            SoundPlayer.Instance.PlayPlatformCrashesSound();
            rb.isKinematic = false;
            ForceAdded(rb);
        }
    }
    private void ForceAdded(Rigidbody rb)
    {
        int rnd = Random.Range(0, 4);
            Vector3 forceVector = Vector3.down;
            switch (rnd) 
        {
            case 0:
                forceVector = Vector3.forward;
                break;
            case 1:
                forceVector = Vector3.down;
                break;
            case 2:
                forceVector = Vector3.left;
                break;
            case 3:
                forceVector = -Vector3.forward;
                break;

        }
        rb.AddForce(forceVector * 10, ForceMode.Impulse);
        GetComponent<Collider>().enabled = false;

    }
}
