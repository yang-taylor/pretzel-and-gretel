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
    
    void toLevel1() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel1();
    }
            
    void toLevel2() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel2();
    }
            
    void toLevel3() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel3();
    }
            
    void toYouLost() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toYouLost();
    }
            
    void toCutscene1() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene1();
    }
            
    void toCutscene2() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene2();
    }
            
    void toCutscene3() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene3();
    }
            
    void toCutscene4() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene4();
    }
            
    void toCutscene5() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene5();
    }
            
    void toCutscene6() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toIntro();
    }
            
    void toLevel3Chase() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel3Chase();
    }
            
    void toLevel2Chase() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel2Chase();
    }
            
    void toLevel1Chase() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel1Chase();
    }
            
    void toOutro() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toOutro();
    }
            
    void toYouWon() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toYouWon();
    }
}
