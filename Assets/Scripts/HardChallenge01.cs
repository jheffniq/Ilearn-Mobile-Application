using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardChallenge01 : MonoBehaviour
{
    
    public GameObject Success;
    public GameObject Fail;
    public GameObject Win;

    public GameObject[] Question;
    public GameObject[] Target;
    public GameObject[] buttonQuestion;
    public GameObject[] Cross;

    public ParticleSystem Confetti;

    Animator coverDown;

    public int Lives;
    public int currentLevel;

    public GameObject tutorialCard;
    

    // Start is called before the first frame update
    void Start()
    {
        coverDown = Success.GetComponent<Animator>();
        coverDown.enabled=false;
    }

    public void clearedQuestion(){
        for(int i = 0; i < Target.Length; i++){
            if (i + 1 == currentLevel){
                Question[i].SetActive(false);
                Question[i+1].SetActive(true);
                
                StartCoroutine(changeTarget(i));
            }
        }
        Success.SetActive(false);
    }

    IEnumerator changeTarget(int i){
        yield return new WaitForSecondsRealtime(2);
        Target[i].SetActive(false);
        Target[i+1].SetActive(true);
    }

    public void levelCounter(){
        currentLevel++;
    }
    public void lifeCounter(){
        Lives--;
    }

    public void showSuccess(){
       
        StartCoroutine(Animate());
    }
    IEnumerator Animate(){
        yield return new WaitForSecondsRealtime(2);
        Success.SetActive(true);
        for(int i = 0; i < buttonQuestion.Length; i++){
            if(i + 1 == currentLevel){
                buttonQuestion[i].SetActive(true);
                Target[i].SetActive(false);

            }
            else{
                buttonQuestion[i].SetActive(false);
            }
        }
        coverDown.enabled=true;
    }

    // Update is called once per frame
    void Update()
    {


        if (Lives == 2){
            Cross[0].SetActive(true);
        }
        if (Lives == 1){
            Cross[1].SetActive(true);
        }
        if (Lives == 0){
            Cross[2].SetActive(true);
            Fail.SetActive(true);
            for (int i = 0; i < Target.Length; i++){
                Target[i].SetActive(false);
            }
        }
    }

    public void resetState(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit(){
        SceneManager.LoadScene("ChallengeMenu");
    }
    public void winScreen(){
        for (int i = 0; i < Target.Length; i++){
            Target[i].SetActive(false);
            Win.SetActive(true);
            PlayerPrefs.SetInt("Win", 1);
        }
    }
    public void startHard(){
        tutorialCard.SetActive(false);
        Target[0].SetActive(true);
    }

}
