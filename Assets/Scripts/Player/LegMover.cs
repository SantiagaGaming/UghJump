using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegMover : MonoBehaviour
{
    [SerializeField] private PlayerJumper _playerJumper;

    [SerializeField] private GameObject _playerLegs;
    private bool _canJump = true;
    private void OnEnable()
    {
        _playerJumper.JumpEvent += OnMoveLegs;
    }
    private void OnDisable()
    {
        _playerJumper.JumpEvent -= OnMoveLegs;
    }

    private void OnMoveLegs()
    {
        if(_canJump)
        StartCoroutine(MoveLegsCo());
    }
    private IEnumerator MoveLegsCo()
    {
        _canJump = false;
        int mover = 0;
        while(mover<10)
        {
            yield return new WaitForSeconds(0.025f);
            _playerLegs.transform.localPosition += new Vector3(0,0 , 0.1f);
            mover++;    
        }
        while (mover>0)
        {
            yield return new WaitForSeconds(0.025f);
            _playerLegs.transform.localPosition -= new Vector3(0,0 , 0.1f);
            mover--;
        }
        _canJump = true;
    }

}
