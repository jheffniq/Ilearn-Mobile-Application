using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LessonSelect : MonoBehaviour
{
    public void GoBack ()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void ToLesson1()
    {
        SceneManager.LoadScene("Lforms&Wforms");
    }

        public void ToLesson2()
    {
        SceneManager.LoadScene("Planets");
    }

    public void ToLesson3()
    {
        SceneManager.LoadScene("Constellations");
    }
}
