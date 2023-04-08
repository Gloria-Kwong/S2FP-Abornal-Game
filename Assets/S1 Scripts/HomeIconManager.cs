using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeIconManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject menuOne;
    public GameObject solidBackground;
    public GameObject canvasBar;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }


    public void Menu1()//paused window closes and background returns normal
    {
        gameManager.SetPaused(false);
        menuOne.SetActive(true);
        solidBackground.SetActive(true);
        canvasBar.SetActive(false);

    }
}
