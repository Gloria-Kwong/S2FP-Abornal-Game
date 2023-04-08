using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartIconIIManager : MonoBehaviour
{
    private GameObject gameScript;
    public GameObject restartButton;//??+

    // Start is called before the first frame update
    void Start()
    {
        gameScript = GameObject.Find("GameScript");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()//click the restart button and restart the scene
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SceneTwo");
        }
    }//??+
}
