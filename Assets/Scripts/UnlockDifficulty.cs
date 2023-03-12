using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockDifficulty : MonoBehaviour
{
    public Button[] challengeButtons;
    public int levelAt;

    public GameObject Astronaut;
    public GameObject Rocket;
    public GameObject[] Trophy;
    public GameObject Reset;



    void Start()
    {

        int levelAt = PlayerPrefs.GetInt("levelAt", 6);
        int Win = PlayerPrefs.GetInt("Win");

        if (Win !=1){
        for (int i = 0; i < challengeButtons.Length; i++ ){
            if (i  + 6 > levelAt){
                challengeButtons[i].interactable = false;
            }
        }
        }
      if (Win == 1){
      Astronaut.SetActive(false);
      Rocket.SetActive(false);
      Reset.SetActive(true);
      foreach(GameObject T  in Trophy){
        T.SetActive(true);
      }
      }
    }

  void Update(){

  }
}
