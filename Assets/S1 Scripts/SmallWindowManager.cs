using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallWindowManager : MonoBehaviour
{
    private GameObject gameManager;
    public GameObject smallWindow;//??+
    public GameObject menuOne;
    public GameObject solidBackground;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()//click the restart button and restart the scene
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SceneOne");
        }
        StartCoroutine(Menu1());
    }//??+


    IEnumerator Menu1()//paused window closes and background returns normal
    {
        yield return new WaitForSeconds(0);
        menuOne.SetActive(false);
        solidBackground.SetActive(false);
    }
}
