using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UrlHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void downloadPDF(){
        //Application.OpenURL("https://drive.google.com/u/0/uc?id=1K0oRXyLUcCdy6KJ2PBwKQgrEzAa-OUV3&export=download");
        Application.OpenURL("https://drive.google.com/u/0/uc?id=1WP4pq1j0tdVDHT_TPt32mZ2mIlHq99ZS&export=download");
        
    }
    public void Exit(){
        SceneManager.LoadScene("Main Menu");
    }
}
