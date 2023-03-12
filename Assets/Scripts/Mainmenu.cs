using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void StartLesson ()
    {
        SceneManager.LoadScene("Lesson Menu");
    }
    public void StartChallege()
    {
        SceneManager.LoadScene("ChallengeMenu");

    }
    public void openHelp(){
        SceneManager.LoadScene("About");
    }
    public void openCredits(){
        SceneManager.LoadScene("Credits");
    }

    public void Quit ()
    {
        Application.Quit();
    }

}
