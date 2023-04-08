using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScripts : MonoBehaviour
{
    private GameManager gameManager;
    public TMP_Text pointsText;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        pointsText.text = gameManager.GetPointsText();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
