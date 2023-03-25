using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailManager : MonoBehaviour
{
    private GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()//click the nails and disappear
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            gameManager.GetComponent<GameManager>().SetNails();
        }
    }
}
