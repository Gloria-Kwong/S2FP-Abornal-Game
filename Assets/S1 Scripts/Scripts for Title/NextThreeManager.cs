using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextThreeManager : MonoBehaviour
{
    public GameObject dialogueFour;

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
        DialogueFour();
    }

    private void DialogueFour()
    {
        dialogueFour.SetActive(true);
    }
}
