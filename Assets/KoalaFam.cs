using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KoalaFam : MonoBehaviour
{

    public KoalaManager koala1;
    public KoalaManager koala2;
    public KoalaManager koala3;
    public GameObject winWindow;
    public GameObject transparentBackground;
    public GameObject pausedIcon;
    private GameManager gameManager;
    public TMP_Text pointsText;
    private bool gameWon = false;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (koala1.GetKoala() == 1 && koala2.GetKoala() == 5 && koala3.GetKoala() == 3 && !gameWon) {
            gameWon = true;
            gameManager.AddPoints(50);
            pointsText.text = gameManager.GetPointsText();
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1);
        winWindow.SetActive(true);
        transparentBackground.SetActive(true);
        pausedIcon.SetActive(false);
    }
}
