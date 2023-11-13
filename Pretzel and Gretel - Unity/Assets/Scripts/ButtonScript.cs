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
    
    public void toTitle() {
    	GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toTitle();
    }
    
    public void toIntro() {
    	GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toIntro();
    }
    
    public void toLevel1() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel1();
    }
            
    public void toLevel2() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel2();
    }
            
    public void toLevel3() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel3();
    }
            
    public void toYouLost() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toYouLost();
    }
            
    public void toCutscene1() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene1();
    }
            
    public void toCutscene2() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene2();
    }
            
    public void toCutscene3() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene3();
    }
            
    public void toCutscene4() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene4();
    }
            
    public void toCutscene5() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toCutscene5();
    }
            
    public void toCutscene6() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toIntro();
    }
            
    public void toLevel3Chase() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel3Chase();
    }
            
    public void toLevel2Chase() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel2Chase();
    }
            
    public void toLevel1Chase() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toLevel1Chase();
    }
            
    public void toOutro() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toOutro();
    }
            
    public void toYouWon() {
        GameManager gameManager = FindObjectOfType<GameManager>();
    	gameManager.toYouWon();
    }
}
