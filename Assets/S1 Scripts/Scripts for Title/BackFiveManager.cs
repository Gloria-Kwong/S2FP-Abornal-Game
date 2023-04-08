using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackFiveManager : MonoBehaviour
{
    public GameObject dialogueFour;
    public GameObject dialogueFive;

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
        StartCoroutine(DialogueFour());
    }

    IEnumerator DialogueFour()
    {
        yield return new WaitForSeconds(0);
        dialogueFour.SetActive(true);
        dialogueFive.SetActive(false);
    }
}
