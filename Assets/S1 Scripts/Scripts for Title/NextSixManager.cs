using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSixManager : MonoBehaviour
{
    public GameObject dialogueSeven;

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
        StartCoroutine(DialogueSeven());
    }

    IEnumerator DialogueSeven()
    {
        yield return new WaitForSeconds(0);
        dialogueSeven.SetActive(true);
    }
}
