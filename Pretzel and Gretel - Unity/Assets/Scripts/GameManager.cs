using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private AudioManager audioManager;
    
    // Start is called before the first frame update
    void Start()
    {
    	audioManager = GetComponent<AudioManager>();
    	audioManager.playTheme();
    	DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void toTitle() {
        	SceneManager.LoadScene("Title");
        	audioManager.playTheme();
        }
        
        public void toIntro() {
        	SceneManager.LoadScene("Intro");
        	audioManager.introVoice();
        }
        
        public void toLevel1() {
            SceneManager.LoadScene("Level 1");
            audioManager.playMaze();
            audioManager.stopVoice();
        }
        
        public void toLevel2() {
        	SceneManager.LoadScene("Level 2");
        }
        
        public void toLevel3() {
            SceneManager.LoadScene("Level 3");
        }
        
        public void toYouLost() {
        	SceneManager.LoadScene("You Lost");
        	audioManager.stopMusic();
        }
        
        public void toCutscene1() {
        	SceneManager.LoadScene("Cutscene1");
        	audioManager.playTheme();
        	audioManager.c1Voice();
        }
        
        public void toCutscene2() {
        	SceneManager.LoadScene("Cutscene 2");
        	audioManager.c2Voice();
        }
        
        public void toCutscene3() {
            SceneManager.LoadScene("Cutscene 3");
            audioManager.c3Voice();
        }
        
        public void toCutscene4() {
            SceneManager.LoadScene("Cutscene 4");
            audioManager.c4Voice();
        }
        
        public void toCutscene5() {
            SceneManager.LoadScene("Cutscene 5");
            audioManager.c5Voice();
        }
        
        public void toCutscene6() {
            SceneManager.LoadScene("Cutscene 6");
            audioManager.c6Voice();
        }
        
        public void toLevel3Chase() {
            SceneManager.LoadScene("Level 3 Chase");
            audioManager.playChase();
            audioManager.stopVoice();
        }
        
        public void toLevel2Chase() {
            SceneManager.LoadScene("Level 2 Chase");
        }
        
        public void toLevel1Chase() {
            SceneManager.LoadScene("Level 1 Chase");
        }
        
        public void toOutro() {
            SceneManager.LoadScene("Outro");
            audioManager.playTheme();
            audioManager.outroVoice();
        }
        
        public void toYouWon() {
            SceneManager.LoadScene("You Won");
            audioManager.stopVoice();
    }
}
