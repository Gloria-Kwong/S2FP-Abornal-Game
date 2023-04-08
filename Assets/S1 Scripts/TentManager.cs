using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentManager : MonoBehaviour
{
    private GameManager gameManager;
    //private int tentIdle = 0;
    public GameObject rabbitAngry;
    public GameObject loseWindow;//??+
    public GameObject transparentBackground;
    public GameObject pausedIcon;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()//click the tent and rabbit anger
    {
        if (!gameManager.GetPaused()) {
            StartCoroutine(RabbitAngry());
            StartCoroutine(Lose());//??+
        }
    }

    IEnumerator RabbitAngry()
    {
        yield return new WaitForSeconds(1);//Rabbit angers a few seconds delay
        rabbitAngry.SetActive(true);
    }

    IEnumerator Lose()//??+
    {
        yield return new WaitForSeconds(3);
        transparentBackground.SetActive(true);
        loseWindow.SetActive(true);
        pausedIcon.SetActive(false);
        gameManager.SetPaused(true);
    }

}
