using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------- Audio Source -------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource voiceSource;
    [SerializeField] AudioSource fxSource;
    
    [Header("-------------  Audio Clip  -------------")]
    public AudioClip introVoiceover;
    public AudioClip cutscene1Voiceover;
    public AudioClip cutscene2Voiceover;
    public AudioClip cutscene3Voiceover;
    public AudioClip cutscene4Voiceover;
    public AudioClip cutscene5Voiceover;
    public AudioClip cutscene6Voiceover;
    public AudioClip outroVoiceover;
    public AudioClip button;
    public AudioClip crumbDrop;
    public AudioClip nomNom;
    public AudioClip witchLaugh;
    public AudioClip youLost;
    public AudioClip youWon;
    public AudioClip chaseMusic;
    public AudioClip mazeMusic;
    public AudioClip themeMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        //playTheme();
    }
    
    public void stopVoice() {
    voiceSource.Stop();
    }
    
    public void introVoice() {
    	Debug.Log("Made it to introVoice()");
    	voiceSource.Stop();
    	voiceSource.clip = introVoiceover;
    	Debug.Log("introVoiceover should've played");
    	voiceSource.Play();
    }
    
    public void c1Voice() {
    voiceSource.Stop();
        voiceSource.clip = cutscene1Voiceover;
        voiceSource.Play();
    }
    
    public void c2Voice() {
    voiceSource.Stop();
            voiceSource.clip = cutscene2Voiceover;
            voiceSource.Play();
    }
    
    public void c3Voice() {
    voiceSource.Stop();
            voiceSource.clip = cutscene3Voiceover;
            voiceSource.Play();
    }
    
    public void c4Voice() {
    voiceSource.Stop();
            voiceSource.clip = cutscene4Voiceover;
            voiceSource.Play();
    }
    
    public void c5Voice() {
    voiceSource.Stop();
            voiceSource.clip = cutscene5Voiceover;
            voiceSource.Play();
    }
    
    public void c6Voice() {
    voiceSource.Stop();
            voiceSource.clip = cutscene6Voiceover;
            voiceSource.Play();
    }
    
    public void outroVoice() {
    	voiceSource.Stop();
    	voiceSource.clip = outroVoiceover;
        voiceSource.Play();
    }
    
    public void stopMusic() {
    	musicSource.Stop();
    }
    
    public void playChase() {
    	musicSource.Stop();
    	musicSource.clip = chaseMusic;
    	musicSource.loop = true;
    	musicSource.Play();
    }
    
    public void playMaze() {
    	musicSource.Stop();
        musicSource.clip = mazeMusic;
        musicSource.loop = true;
    	musicSource.Play();
    }
    
    public void playTheme() {
  	musicSource.Stop();
        musicSource.clip = themeMusic;
        musicSource.loop = true;
    	musicSource.Play();
    }
    
    public void playFX(AudioClip clip) {
    	fxSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
