using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MediumManager : MonoBehaviour
{
    public int score;
    public int Proceed;
    public int Complete = 0;
    public float Time = 0.5f;
    
    public GameObject Results;
    public GameObject Snaps;
    public GameObject planets;
    //public GameObject titleCard;
    //public GameObject selectBar;

    public GameObject Star;
    public GameObject Diamond;
    public GameObject Key;
    public GameObject ScoreTip;
    public GameObject WinTip;

    public GameObject retryButton;
    public GameObject exitButton;
    public GameObject continueButton;

    public GameObject ministar;
    public GameObject minidiamond;
    public GameObject minikey;

    public GameObject tutorial;
    public GameObject tutorialButton;

    /* public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;

    public Vector3 resetMercury;
    public Vector3 resetVenus;
    public Vector3 resetEarth;
    public Vector3 resetMars;
    public Vector3 resetJupiter;
    public Vector3 resetSaturn;
    public Vector3 resetUranus;
    public Vector3 resetNeptune; */

    void Start()
    {
        Snaps.SetActive(false);
        planets.SetActive(false);
        /* Proceed = planets.transform.childCount;
        Mercury = GameObject.Find("Mercury");
        Venus = GameObject.Find("Venus");
        Earth = GameObject.Find("Earth");
        Mars = GameObject.Find("Mars");
        Jupiter = GameObject.Find("Jupiter");
        Saturn = GameObject.Find("Saturn");
        Uranus = GameObject.Find("Uranus");
        Neptune = GameObject.Find("Neptune");

        resetMercury = Mercury.transform.position;
        resetVenus = Venus.transform.position;
        resetEarth = Earth.transform.position;
        resetMars = Mars.transform.position;
        resetJupiter = Jupiter.transform.position;
        resetSaturn = Saturn.transform.position;
        resetUranus = Uranus.transform.position;
        resetNeptune = Neptune.transform.position; */
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 1){
            ministar.SetActive(true);   
        }
        if (score == 4){
            minidiamond.SetActive(true);
        }
        if(score == 8){
            minikey.SetActive(true);
        }

        if (Complete == 8 ){

            Results.SetActive(true);
            Snaps.SetActive(false);
            planets.SetActive(false);
            //titleCard.SetActive(false);
            //selectBar.SetActive(false);

            if (score <= 3){
                Star.SetActive(true);
                ScoreTip.SetActive(true);
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
            else if (score >= 4 && score <= 7){
                Star.SetActive(true);
                StartCoroutine(showDiamond());
                ScoreTip.SetActive(true);
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
            else if (score == 8){
                Star.SetActive(true);
                StartCoroutine(showDiamond());
                StartCoroutine(showKey());
                ScoreTip.SetActive(false);
                WinTip.SetActive(true);
                continueButton.SetActive(true);
                Success(); 
            }
            /*(Mercury.transform.position = resetMercury;
            Venus.transform.position = resetVenus;
            Earth.transform.position = resetEarth;
            Mars.transform.position = resetMars;
            Jupiter.transform.position = resetJupiter;
            Saturn.transform.position = resetSaturn;
            Uranus.transform.position = resetUranus;
            Neptune.transform.position = resetNeptune;

            Mercury.GetComponent<DragDrop>().placed=false;
            Venus.GetComponent<DragDrop>().placed=false;
            Earth.GetComponent<DragDrop>().placed=false;
            Mars.GetComponent<DragDrop>().placed=false;
            Jupiter.GetComponent<DragDrop>().placed=false;
            Saturn.GetComponent<DragDrop>().placed=false;
            Uranus.GetComponent<DragDrop>().placed=false;
            Neptune.GetComponent<DragDrop>().placed=false;*/
            
        }

    }

    IEnumerator showDiamond(){

        yield return new WaitForSecondsRealtime(Time);
        Diamond.SetActive(true);
        
    }

    IEnumerator showKey(){
        yield return new WaitForSecondsRealtime(1);
        Key.SetActive(true);
        
    }
    
    public void startChallenge(){
        tutorial.SetActive(false);
        tutorialButton.SetActive(false);
        Snaps.SetActive(true);
        planets.SetActive(true);

    }

    public void addScore(){
        score++;

    }
    
    public void Completion(){
        Complete++;
    }

    public void Retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit(){
        SceneManager.LoadScene("ChallengeMenu");
    }

    public void Success(){
        if (score >= 7 && score <= 10){
            PlayerPrefs.SetInt("levelAt", 8);
        }
    }
}
