using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChallengeSelect : MonoBehaviour
{
    public void GoBack ()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Easy()
    {
        /*LoadEasy*/
        SceneManager.LoadScene("Easy");
        
    }

        public void Medium()
    {
        SceneManager.LoadScene("Medium");
    }

    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }
    public void Reset(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
