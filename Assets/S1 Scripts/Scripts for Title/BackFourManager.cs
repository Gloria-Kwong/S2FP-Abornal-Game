using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackFourManager : MonoBehaviour
{
    public GameObject dialogueThree;
    public GameObject dialogueFour;

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
        StartCoroutine(DialogueThree());
    }

    IEnumerator DialogueThree()
    {
        yield return new WaitForSeconds(0);
        dialogueThree.SetActive(true);
        dialogueFour.SetActive(false);
    }
}
