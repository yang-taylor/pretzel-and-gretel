using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void toIntro() {
    	SceneManager.LoadScene("Intro");
    }
    
    public void toLevel1() {
        SceneManager.LoadScene("Level 1");
    }
    
    public void toLevel2() {
    	SceneManager.LoadScene("Level 2");
    }
    
    public void toLevel3() {
        SceneManager.LoadScene("Level 3");
    }
    
    public void toCutscene1() {
    	SceneManager.LoadScene("Cutscene 1");
    }
    
    public void toCutscene2() {
    	SceneManager.LoadScene("Cutscene 2");
    }
    
    public void toCutscene3() {
        SceneManager.LoadScene("Cutscene 3");
    }
    
    public void toCutscene4() {
        SceneManager.LoadScene("Cutscene 4");
    }
    
    public void toCutscene5() {
        SceneManager.LoadScene("Cutscene 5");
    }
    
    public void toCutscene6() {
        SceneManager.LoadScene("Cutscene 6");
    }
    
    public void toLevel3Chase() {
        SceneManager.LoadScene("Level 3 Chase");
    }
    
    public void toLevel2Chase() {
        SceneManager.LoadScene("Level 2 Chase");
    }
    
    public void toLevel1Chase() {
        SceneManager.LoadScene("Level 1 Chase");
    }
    
    public void toOutro() {
        SceneManager.LoadScene("Outro");
    }
    
    public void toYouWon() {
        SceneManager.LoadScene("You Won");
    }
}
