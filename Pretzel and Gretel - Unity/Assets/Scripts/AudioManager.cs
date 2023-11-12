using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource fxSource;
    
    [SerializeField] AudioClip walking;
    [SerializeField] AudioClip scream;
    [SerializeField] AudioClip button;
    [SerializeField] AudioClip witchLaugh;
    [SerializeField] AudioClip backgroundMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }
    
    public void FXWalking() {
    	fxSource.PlayOneShot(walking);
    }
    
    public void FXScream() {
    	fxSource.PlayOneShot(scream);
    }
    
    public void FXButton() {
    	fxSource.PlayOneShot(button);
    }
    
    public void FXWitch() {
    	fxSource.PlayOneShot(witchLaugh);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
