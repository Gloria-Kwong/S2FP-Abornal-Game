using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOneNineManager : MonoBehaviour
{
    public GameObject dialogueTwoOne;

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
        StartCoroutine(DialogueTwoOne());
    }

    IEnumerator DialogueTwoOne()
    {
        yield return new WaitForSeconds(0);
        dialogueTwoOne.SetActive(true);
    }
}
