using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void toTitle() {
    	GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toTitle();
    }
    
    void toIntro() {
    	GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toIntro();
    }
}
