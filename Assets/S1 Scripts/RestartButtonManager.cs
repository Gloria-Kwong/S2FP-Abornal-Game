using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject restartButton;//??+

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()//click the restart button and restart the scene
    {
        if (Input.GetMouseButtonDown(0))
        {   
            gameManager.SetPaused(false);
            SceneManager.LoadScene("SceneOne");
        }
    }//??+
}

   

