using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOCancelIconManager : MonoBehaviour
{
    private GameObject gameManager;
    public GameObject hintOne;
    public GameObject transparentBackground;
    public GameObject pausedIcon;

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
        StartCoroutine(HintOne());
    }

    IEnumerator HintOne()//paused window closes and background returns normal
    {
        yield return new WaitForSeconds(0);
        hintOne.SetActive(false);
        transparentBackground.SetActive(false);
        pausedIcon.SetActive(true);
    }
}
