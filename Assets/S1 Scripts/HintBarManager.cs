using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintBarManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject hintFive;
    public GameObject transparentBackground;
    public GameObject pausedIcon;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager
        gameManager = GameManager.instance;
    }


    public void HintFive()//paused window pops up and background dark
    {
        gameManager.SetPaused(true);
        hintFive.SetActive(true);
        transparentBackground.SetActive(true);
        pausedIcon.SetActive(false);
    }
}
