using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallWindowIIIManager : MonoBehaviour
{
    private GameObject gameScripts;

    // Start is called before the first frame update
    void Start()
    {

        gameScripts = GameObject.Find("GameScripts");
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }
}
