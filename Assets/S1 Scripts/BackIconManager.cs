using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackIconManager : MonoBehaviour
{
    private GameObject gameManager;
    public GameObject backIcon;//??+
    public GameObject titlePage;

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
        titlePage.SetActive(true);
    }//??+
}
