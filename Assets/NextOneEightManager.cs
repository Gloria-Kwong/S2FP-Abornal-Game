using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOneEightManager : MonoBehaviour
{
    public GameObject dialogueOneNine;

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
        StartCoroutine(DialogueOneNine());
    }

    IEnumerator DialogueOneNine()
    {
        yield return new WaitForSeconds(0);
        dialogueOneNine.SetActive(true);
    }
}
