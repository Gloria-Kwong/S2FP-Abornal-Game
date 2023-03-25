using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScript : MonoBehaviour
{

    public TMP_Text pointsText;
    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = GameManager.points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
