using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARButtons : MonoBehaviour
{

    
    public AudioSource soundPlayer;
    public GameObject Teacher;
    public GameObject Model;
    public GameObject Prompt;
    public GameObject pauseButton;
    public GameObject playButton;

    Animator anim;

    void Start() {
         anim = Teacher.GetComponent<Animator>();

    }

    public void ToggleSound()
    {   if(!soundPlayer.isPlaying){
        soundPlayer.Play();
        }
        else{
            soundPlayer.Pause();
        }
        
    }
    public void StopSound(){
        soundPlayer.Stop();
    }
    
    public void ShowPrompt(){
        Prompt.SetActive(true);
    }
    public void ClosePrompt(){
        Prompt.SetActive(false);
    }
    
   void Update() {
        
        if (!soundPlayer.isPlaying){
            anim.Play("Idle");
            pauseButton.SetActive(false);
            playButton.SetActive(true);
        }
        else{
            anim.Play("Talking");
            playButton.SetActive(false);
            pauseButton.SetActive(true);
        }
    
    }      
 
}
