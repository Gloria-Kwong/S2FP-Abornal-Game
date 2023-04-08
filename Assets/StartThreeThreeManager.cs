using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartThreeThreeManager : MonoBehaviour
{
    private GameObject gameTitleScript;

    // Start is called before the first frame update
    void Start()
    {
        gameTitleScript = GameObject.Find("GameTitleScript");
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }
}
