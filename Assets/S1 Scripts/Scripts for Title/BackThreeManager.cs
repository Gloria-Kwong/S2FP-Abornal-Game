using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackThreeManager : MonoBehaviour
{
    public GameObject dialogueTwo;
    public GameObject dialogueThree;

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
        StartCoroutine(DialogueTwo());
    }

    IEnumerator DialogueTwo()
    {
        yield return new WaitForSeconds(0);
        dialogueTwo.SetActive(true);
        dialogueThree.SetActive(false);
    }
}
