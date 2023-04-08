using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailManager : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()//click the nails and disappear
    {
        if (Input.GetMouseButtonDown(0) && !gameManager.GetPaused())
        {
            Destroy(gameObject);
            gameManager.GetComponent<GameManager>().SetNails();
        }
    }
}
