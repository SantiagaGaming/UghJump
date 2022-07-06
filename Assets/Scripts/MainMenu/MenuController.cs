using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private View _view;
    private void OnEnable()
    {
        _view.StartButtonTapEvent += OnStartGame;
    }
    private void OnDisable()
    {
        _view.StartButtonTapEvent -= OnStartGame;
    }
    public void OnStartGame()
    {
        _sceneLoader.LoadScene("Game");
    }    

}
