using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFourManager : MonoBehaviour
{
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
        StartCoroutine(DialogueFive());
    }

    IEnumerator DialogueFive()
    {
        yield return new WaitForSeconds(0);
        dialogueFive.SetActive(true);
    }
}
