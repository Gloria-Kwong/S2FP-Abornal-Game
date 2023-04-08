using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject bomb;
    public GameObject bombBomb;
    public GameObject loseWindow;
    public GameObject transparentBackground;
    public GameObject pausedIcon;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(Bomb());
        StartCoroutine(BombBomb());
        StartCoroutine(LoseWindow());
    }

    IEnumerator Bomb()
    {
        yield return new WaitForSeconds(0);
        bomb.SetActive(true);
    }

    IEnumerator BombBomb()
    {
        yield return new WaitForSeconds(1);
        bombBomb.SetActive(true);
    }

    IEnumerator LoseWindow()
    {
        yield return new WaitForSeconds(2);
        loseWindow.SetActive(true);
        transparentBackground.SetActive(true);
        pausedIcon.SetActive(false);
    }
}
