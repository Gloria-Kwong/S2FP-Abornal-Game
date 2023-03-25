using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int nailsFuund = 0;
    public Animator anim;
    public GameObject rabbitDying;
    public GameObject winWindow;//??+
    public GameObject transparentBackground;
    public TMP_Text pointsText;

    public static int points = 50;

    public void SetNails()
    {
        nailsFuund +=1;
    }


    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = points.ToString();
    } 

    // Update is called once per frame
    void Update()
    {
        if (nailsFuund >= 3)//if 3 nails disappear, the tent crushes
        {
            anim.SetBool("IsCrush", true);
            StartCoroutine(RabbitDying());//if 3 nails disappear, the Rabbit dies
            StartCoroutine(Win());
            nailsFuund = 0;
        }
    }

    IEnumerator RabbitDying()
    {
        yield return new WaitForSeconds(1);//Rabbit dies a few seconds delay
        rabbitDying.SetActive(true);
    }

    IEnumerator Win()
    {
        points += 50;
        pointsText.text = points.ToString();
        yield return new WaitForSeconds(3);
        winWindow.SetActive(true);
        transparentBackground.SetActive(true);
    }
}
