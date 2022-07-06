using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public UnityAction StartButtonTapEvent;
    [SerializeField] private Button _startGameButton;
    private void Start()
    {
        _startGameButton.onClick.AddListener(StartButtonTapEvent);
    }
}
