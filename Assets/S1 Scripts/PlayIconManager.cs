using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayIconManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject pausedWindow;
    public GameObject transparentBackground;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void PausedWindow()//paused window closes and background returns normal
    {
        gameManager.SetPaused(false);
        pausedWindow.SetActive(false);
        transparentBackground.SetActive(false);
    }
}
