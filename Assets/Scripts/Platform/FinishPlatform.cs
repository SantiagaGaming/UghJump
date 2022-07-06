using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : Platform
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            GameManager manager = FindObjectOfType<GameManager>();
            manager.EndGame(true);

        }
    }
}
