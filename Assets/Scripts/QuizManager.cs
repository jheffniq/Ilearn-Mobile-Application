using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public GameObject[] Levels;
    public GameObject tempGameObject;
    public GameObject Results;
    public GameObject Diamond;
    public GameObject Star;
    public GameObject Key;
    public GameObject ScoreTip;
    public GameObject WinTip;

    public GameObject retryButton;
    public GameObject exitButton;
    public GameObject continueButton;

    public int currentLevel;
    public int score;
    public float Time = 0.5f;

    public TextMeshProUGUI showScore;

    public AudioSource correctSound;
    public AudioSource wrongSound;
    public AudioSource Reward;

    public GameObject tutorialCard;
    public GameObject tutorialButton;

    public GameObject miniStar;
    public GameObject miniDiamond;
    public GameObject miniKey;

    void Start(){
        randomizeLevel();
    }

    public void randomizeLevel(){
            for (int i = 1; i < Levels.Length; i++){
            int random = Random.Range(1, Levels.Length);
            tempGameObject = Levels[random];
            Levels[random] = Levels[i];
            Levels[i] = tempGameObject;
        }
    }
    
    public void correctAnswer(){
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);
            correctSound.Play();
            score++;
            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }

        else
        {
            score++;
            if (score <= 3){
                Star.SetActive(true);
                ScoreTip.SetActive(true);
                retryButton.SetActive(true);
                exitButton.SetActive(true);

            }
            else if (score >= 4 && score <= 6){
                Star.SetActive(true);
                StartCoroutine(showDiamond());
                ScoreTip.SetActive(true);
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
            else if (score >= 7 && score <= 10){
                Star.SetActive(true);
                StartCoroutine(showDiamond());
                StartCoroutine(showKey());
                WinTip.SetActive(true);
                continueButton.SetActive(true);
            }
            Results.SetActive(true);
        }
    }

    public void wrongAnswer(){
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);
            wrongSound.Play();
            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }

        else
        {
            if (score <= 3){
                Star.SetActive(true);
                ScoreTip.SetActive(true);
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
            else if (score >= 4 && score <= 6){
                Star.SetActive(true);
                StartCoroutine(showDiamond());
                ScoreTip.SetActive(true);
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
            else if (score >= 7 && score <= 10){
                Star.SetActive(true);
                StartCoroutine(showDiamond());
                StartCoroutine(showKey());
                WinTip.SetActive(true);
                continueButton.SetActive(true);
            }
            Results.SetActive(true);
        }
    }

    public void Retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    IEnumerator showDiamond(){

        yield return new WaitForSecondsRealtime(Time);
        Diamond.SetActive(true);
        
    }

    IEnumerator showKey(){
        yield return new WaitForSecondsRealtime(1);
        Key.SetActive(true);
        
    }

    public void Success(){
        if (score >= 7 && score <= 10){
            PlayerPrefs.SetInt("levelAt", 7);
        }
    }
    public void startChallenge(){
        tutorialCard.SetActive(false);
        tutorialButton.SetActive(false);
    }

    public void Exit(){
        SceneManager.LoadScene("ChallengeMenu");
    }

    void Update(){
        Success();
        if (score == 1){
            miniStar.SetActive(true);
        }
        if (score == 4){
            miniDiamond.SetActive(true);
        }
        if (score == 7){
            miniKey.SetActive(true);
        }

    }



}
