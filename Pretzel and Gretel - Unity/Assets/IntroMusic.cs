using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMusic : MonoBehaviour
{
    private AudioManager audioManager;
    
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GetComponent<AudioManager>();
        //audioManager.introVoice();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
