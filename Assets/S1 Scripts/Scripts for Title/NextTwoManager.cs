using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTwoManager : MonoBehaviour
{
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
        DialogueThree();
    }

    private void DialogueThree()
    {
        dialogueThree.SetActive(true);
    }
}
