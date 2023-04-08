using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TwentyButtonManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject oneHintOne;
    public GameObject hintFive;
    public TMP_Text pointsText; 

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(OneHintOne());
        GameManager.points -= 20;
        if (SceneManager.GetActiveScene().name == "SceneOne")
        {
            gameManager.GetComponent<GameManager>().SetPointsText(GameManager.points);
        }
        else
        {
            pointsText.text = gameManager.GetPointsText();
        }

    }

    IEnumerator OneHintOne()
    {
        yield return new WaitForSeconds(0);
        oneHintOne.SetActive(true);
        hintFive.SetActive(false);
    }
}
