using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KoalaManager : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private int currentKoala = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()//click the restart button and restart the scene
    {
        currentKoala += 1;
        if (currentKoala + 1 > spriteArray.Length) {
            currentKoala = 0;
        }
        spriteRenderer.sprite = spriteArray[currentKoala];
    }

    public int GetKoala() {
        return currentKoala;
    }
}
