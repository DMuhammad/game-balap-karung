using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class scene1 : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play(){
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        string objectName = eventData.pointerCurrentRaycast.gameObject.name;
        if (objectName == "start") { 
            SceneManager.LoadScene("start");
        }else if(objectName == "quit"){
            Debug.Log("Clicked: " + objectName);
        }else if(objectName == "sound") {
            Debug.Log("Clicked: " + objectName);
        }else if(objectName == "informasi") { 
            Debug.Log("Clicked: " + objectName);
        }else if (objectName == "lv1") {
            SceneManager.LoadScene("level2");
        }else if (objectName == "lv2") {
            Debug.Log(objectName + " is locked");
        }else if (objectName == "lv3") {
            Debug.Log(objectName + " is locked");
        }else if (objectName == "lev1") {
            Debug.Log("Clicked: " + objectName);
        }else if (objectName == "lev2") {
            SceneManager.LoadScene("level3");
        }else if (objectName == "lev3") {
            Debug.Log(objectName + " is locked");
        }else if (objectName == "level1") {
            Debug.Log("Clicked: " + objectName);
        }else if (objectName == "level2") {
            Debug.Log("Clicked: " + objectName);
        }else if (objectName == "level3") {
            Debug.Log("Clicked: " + objectName);
        }
    }
}
