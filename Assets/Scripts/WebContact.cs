using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebContact : MonoBehaviour
{
    private void Start(){
        string url= "http://www.google.com";
        StartCoroutine(Get(url));
    }
    
    private IEnumerator Get(string url){
        using (UnityWebRequest webreq = UnityWebRequest.Get(url)){
        yield return webreq.SendWebRequest();
        if (webreq.result == UnityWebRequest.Result.ProtocolError || webreq.result == UnityWebRequest.Result.ConnectionError){
            Debug.Log("Error " + webreq.error);
        }
        else {
            Debug.Log("Received " + webreq.downloadHandler.text);
        }
    }
    }

}
