using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayIconCanvasManager : MonoBehaviour
{
    private GameObject gameManager;
    public GameObject pausedWindow;
    public GameObject transparentBackground;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()//click the play icon and paused window closes
    {
        StartCoroutine(PausedWindow());
    }

    IEnumerator PausedWindow()//paused window closes and background returns normal
    {
        yield return new WaitForSeconds(0);
        pausedWindow.SetActive(false);
        transparentBackground.SetActive(false);
    }
}
