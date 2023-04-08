using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleStartButtonManager : MonoBehaviour
{
    public GameObject dialogueOne;
    
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
        StartCoroutine(DialogueOne());
    }

    IEnumerator DialogueOne()
    {
        yield return new WaitForSeconds(0);
        dialogueOne.SetActive(true);
    }
}

