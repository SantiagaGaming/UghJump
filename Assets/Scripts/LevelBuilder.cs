using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] private GameObject[] _platforms;
    [SerializeField] private GameObject _chrashesPlatform;
    [SerializeField] private Transform _startPos;
    [SerializeField] private GameObject _finishPlatform;
    private int _count;

    private void Start()
    {
        _count = Random.Range(20, 60);
        GenerateLevel();
    }
    private void GenerateLevel()
    {
        int i = 0;
        while (i<=_count)
        {
            var temp = new GameObject();
            if(i%2==0)
            {
              temp = Instantiate(_chrashesPlatform);
            }
            else
            {
                temp = Instantiate(_platforms[Random.Range(0, _platforms.Length)]);
            }
   
            temp.transform.position = _startPos.position;
            RandomizePosition();
            _startPos.position += new Vector3(0, 3, 0);
            i++;
        }
        var finishPlatform = Instantiate(_finishPlatform);
        finishPlatform.transform.position = _startPos.position;
      }
    private void RandomizePosition()
    {
        _startPos.position = new Vector3(_startPos.position.x, _startPos.position.y, Random.Range(-6f, 2.55f));
    }
}
