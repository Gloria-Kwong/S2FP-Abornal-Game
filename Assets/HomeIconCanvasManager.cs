using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeIconCanvasManager : MonoBehaviour
{
    private GameObject gameManager;
    public GameObject menuOne;
    public GameObject solidBackground;
    public GameObject canvasBar;

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
        StartCoroutine(Menu1());
    }

    IEnumerator Menu1()//paused window closes and background returns normal
    {
        yield return new WaitForSeconds(0);
        menuOne.SetActive(true);
        solidBackground.SetActive(true);
        canvasBar.SetActive(false);

    }
}
