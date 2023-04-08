using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFiveManager : MonoBehaviour
{
    public GameObject dialogueSix;

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
        StartCoroutine(DialogueSix());
    }

    IEnumerator DialogueSix()
    {
        yield return new WaitForSeconds(0);
        dialogueSix.SetActive(true);
    }
}
