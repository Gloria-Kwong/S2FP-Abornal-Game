using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextButtonManager : MonoBehaviour
{
    private GameObject gameManager;
    public GameObject nextButton;
    public GameObject dialogueOneEight;
    public GameObject moneybag;
    public GameObject hint;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()//click the restart button and restart the scene
    {

        StartCoroutine(DialogueOneEight());

    }

    IEnumerator DialogueOneEight()
    {
        yield return new WaitForSeconds(0);
        dialogueOneEight.SetActive(true);
        moneybag.SetActive(false);
        hint.SetActive(false);
    }
}
