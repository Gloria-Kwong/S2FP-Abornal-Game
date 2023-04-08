using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTwoThreeManager : MonoBehaviour
{
    public GameObject dialogueTwoFour;

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
        StartCoroutine(DialogueTwoFour());
    }

    IEnumerator DialogueTwoFour()
    {
        yield return new WaitForSeconds(0);
        dialogueTwoFour.SetActive(true);
    }
}
