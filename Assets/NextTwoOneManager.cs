using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTwoOneManager : MonoBehaviour
{
    public GameObject dialogueTwoTwo;

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
        StartCoroutine(DialogueTwoTwo());
    }

    IEnumerator DialogueTwoTwo()
    {
        yield return new WaitForSeconds(0);
        dialogueTwoTwo.SetActive(true);
    }
}
