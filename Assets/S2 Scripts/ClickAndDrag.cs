using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    public GameObject selectedObject;
    Vector3 offset;
    private bool canDrag = false;
    public GameObject winWindow;
    public GameObject transparentBackground;
    public GameObject pausedIcon;
    private GameManager gameManager;
    public TMP_Text pointsText;
    public GameObject nose;

    public Collider2D coneCollider;
    public Collider2D noseCollider;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    void Update()
    {
        if (canDrag) {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
                if (targetObject.CompareTag("Cone"))
                {

                    selectedObject = targetObject.transform.gameObject;

                    offset = selectedObject.transform.position - mousePosition;
                }
            }
            if (selectedObject)
            {
                selectedObject.transform.position = new Vector3(mousePosition.x, mousePosition.y, 10) + offset;

            }
            if (Input.GetMouseButtonUp(0) && selectedObject)
            {
                selectedObject = null;
            }
        }
        
    }

    private void OnMouseDown()
    {
        canDrag = true;
    }

    private void OnMouseUp()
    {
        if (coneCollider.IsTouching(noseCollider)) {
            Debug.Log("It works!");
        }
        //float xPos = gameObject.transform.position.x;
        //float yPos = gameObject.transform.position.y;

        //if (xPos > 0.1 && xPos < 0.2 && yPos > 1.0 && yPos < 1.5)
        //{
        //    gameManager.AddPoints(50);
        //    pointsText.text = gameManager.GetPointsText();
        //    StartCoroutine(WinWindow());
        //}
    }

    IEnumerator WinWindow()
    {
        yield return new WaitForSeconds(0);
        winWindow.SetActive(true);
        transparentBackground.SetActive(true);
        pausedIcon.SetActive(false);
    }

}