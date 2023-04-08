using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackOneEightManager : MonoBehaviour
{
    public GameObject menuTwo;

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
        StartCoroutine(MenuTwo());
    }

    IEnumerator MenuTwo()
    {
        yield return new WaitForSeconds(0);
        menuTwo.SetActive(true);
    }
}
