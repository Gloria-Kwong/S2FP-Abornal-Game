using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelIconManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject hintFive;
    public GameObject transparentBackground;
    public GameObject pausedIcon;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()//click the play icon and paused window closes
    {
        StartCoroutine(HintFive());
    }

    IEnumerator HintFive()//paused window closes and background returns normal
    {
        yield return new WaitForSeconds(0);
        gameManager.SetPaused(false);   
        hintFive.SetActive(false);
        transparentBackground.SetActive(false);
        pausedIcon.SetActive(true);
    }
}
