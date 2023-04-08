using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTwoTwoManager : MonoBehaviour
{
    public GameObject dialogueTwoThree;

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
        StartCoroutine(DialogueTwoThree());
    }

    IEnumerator DialogueTwoThree()
    {
        yield return new WaitForSeconds(0);
        dialogueTwoThree.SetActive(true);
    }
}
