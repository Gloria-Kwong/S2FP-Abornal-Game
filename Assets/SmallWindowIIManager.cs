using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallWindowIIManager : MonoBehaviour
{
    private GameObject gameScript;

    // Start is called before the first frame update
    void Start()
    {
        
        gameScript = GameObject.Find("GameScript");
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
