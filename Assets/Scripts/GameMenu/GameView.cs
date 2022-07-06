using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    public UnityAction RestartButtonEvent;
    public UnityAction ExitButtonEvent;
    [SerializeField] private Text _mainText;
    [SerializeField] private Text _restartButtonText;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private GameObject _menuScreen;
    private void Start()
    {
        _restartButton.onClick.AddListener(RestartButtonEvent);
        _exitButton.onClick.AddListener(ExitButtonEvent);
    }

    public void SetMainText(string text)
    {
        _mainText.text = text;
    }
    public void SetRestartButtonText(string text)
    {
        _restartButtonText.text = text;
    }
    public void ShowMenu(bool value) 
    {
        _menuScreen.SetActive(value);
    }
}
