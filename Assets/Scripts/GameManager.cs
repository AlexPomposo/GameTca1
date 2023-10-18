using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.P))
        {
            ToggleButton();
        }
    }
public void ToggleButton()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}
