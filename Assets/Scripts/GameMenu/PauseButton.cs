using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class PauseButton : MonoBehaviour
{
    public UnityAction PauseButtonPressedEvent;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(PauseButtonPressedEvent);
    }
}
