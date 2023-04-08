using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseIconManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject pausedWindow;
    public GameObject transparentBackground;



    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void PausedWindow()//paused window pops up and background dark
    {
        gameManager.SetPaused(true);
        pausedWindow.SetActive(true);
        transparentBackground.SetActive(true);
    }
}
