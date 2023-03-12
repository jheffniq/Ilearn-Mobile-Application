using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenButton : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("Lesson Menu");
    }
}
