using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameView _gameView;
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private PauseButton _pauseButton;
    [SerializeField] private GameObject _pauseButtonObj;
    private bool _paused = false;
    private void OnEnable()
    {
        _pauseButton.PauseButtonPressedEvent += OnPauseGame;
        _gameView.RestartButtonEvent+=OnRestartGame;
        _gameView.ExitButtonEvent+=OnExitGame;
    }
    private void OnDisable()
    {
        _pauseButton.PauseButtonPressedEvent -= OnPauseGame;
        _gameView.RestartButtonEvent -= OnRestartGame;
        _gameView.ExitButtonEvent -= OnExitGame;
    }

    public void EndGame(bool value)
    {
        if (value)
        {
            _gameView.SetMainText("You Win!");
            _gameView.SetRestartButtonText("Next Level");
        }
        else 
        {
            _gameView.SetMainText("You Lose!");
            _gameView.SetRestartButtonText("Restart Game");
        }
        _gameView.ShowMenu(true);
        _pauseButtonObj.SetActive(false);
        Time.timeScale = 0f;
     
    }
    private void OnRestartGame()
    {
        Time.timeScale = 1f;
        _sceneLoader.LoadScene("Game");
    }
    private void OnExitGame()
    {
        Time.timeScale = 1f;
        _sceneLoader.LoadScene("Menu");
    }
    private void OnPauseGame()
    {
        if(!_paused)
        {
            _paused = true;
            Time.timeScale = 0f;
            _gameView.ShowMenu(true);
            _gameView.SetMainText("Pause");
        }
        else
        {
            _paused = false;
            Time.timeScale = 1f;
            _gameView.ShowMenu(false);
        }
    }
}
