using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOneManager : MonoBehaviour
{
    public GameObject dialogueTwo;

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
        DialogueTwo();
    }

    private void DialogueTwo()
    {
      
        dialogueTwo.SetActive(true);
    }
}
