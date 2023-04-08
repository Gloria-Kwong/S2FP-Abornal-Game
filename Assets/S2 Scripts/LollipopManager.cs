using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopManager : MonoBehaviour
{
    private GameObject gameScript;
    public GameObject loseWindow;
    public GameObject transparentBackground;
    public GameObject pausedIcon;

    // Start is called before the first frame update
    void Start()
    {
        gameScript = GameObject.Find("GameScript");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(Lose1());
    }

    IEnumerator Lose1()
    {
        yield return new WaitForSeconds(0);
        transparentBackground.SetActive(true);
        loseWindow.SetActive(true);
        pausedIcon.SetActive(false);
    }
}
