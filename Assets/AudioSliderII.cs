using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSliderII : MonoBehaviour
{
    public Slider slider;
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetAudio()
    {
        gameObject.GetComponent<AudioSource>().volume = slider.value;
    }
}
