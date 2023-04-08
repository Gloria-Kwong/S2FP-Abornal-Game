using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartIconManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject restartIcon;//??+

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void RestartScene()
    {
        gameManager.SetPaused(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
