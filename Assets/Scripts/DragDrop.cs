using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{   
    public GameObject correctPlanet;
    public GameObject[] wrongPlanet;
    public AudioSource Tap;

    public bool moving;
    public bool placed;
    public Vector3 resetPosition;
    public int score;

    float startPosX;
    float startPosY;

    void Start(){

        resetPosition = this.transform.localPosition;

    }
    void Update(){

        if (placed == false){
            if (moving){
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }

    }
    private void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            GameObject.Find("TapSound").GetComponent<AudioSource>().Play();
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
        }

        moving = true;

    }
    private void OnMouseUp(){

        GameObject.Find("TapSound").GetComponent<AudioSource>().Play();
        moving = false;
        if(Mathf.Abs(this.transform.localPosition.x - correctPlanet.transform.localPosition.x) <= 0.5f &&
        Mathf.Abs(this.transform.localPosition.y - correctPlanet.transform.localPosition.y) <= 0.5f){

            this.transform.localPosition = new Vector3(correctPlanet.transform.localPosition.x, correctPlanet.transform.localPosition.y,
            correctPlanet.transform.localPosition.z);
            if (placed == false){
                GameObject.Find("GameManager").GetComponent<MediumManager>().addScore();
                GameObject.Find("CorrectSound").GetComponent<AudioSource>().Play();
                GameObject.Find("GameManager").GetComponent<MediumManager>().Completion();
            }
            placed = true;




        }
        else{
            foreach(GameObject wrongPlanet in wrongPlanet){
            if(Mathf.Abs(this.transform.localPosition.x - wrongPlanet.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - wrongPlanet.transform.localPosition.y) <= 0.5f){

            this.transform.localPosition = new Vector3(wrongPlanet.transform.localPosition.x, wrongPlanet.transform.localPosition.y,
            wrongPlanet.transform.localPosition.z);
            if (placed == false){
                GameObject.Find("WrongSound").GetComponent<AudioSource>().Play();
                GameObject.Find("GameManager").GetComponent<MediumManager>().Completion();
            }
            placed = true;

            }
            }
        }

    }

}
