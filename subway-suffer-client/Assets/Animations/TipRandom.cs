using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipRandom : MonoBehaviour
{
    public int randNum;
    public GameObject tipDisplay;

    void Start()
    {
        StartCoroutine(tipTracker());
        
    }

    IEnumerator tipTracker(){
        while(true){
        randNum = Random.Range(1,4);
        if(randNum ==1){
            tipDisplay.GetComponentInChildren<Text>().text = " one";
        }
        if(randNum ==2){
            tipDisplay.GetComponentInChildren<Text>().text = " two";
        }
        if(randNum ==3){
            tipDisplay.GetComponentInChildren<Text>().text = " three";
        }
        yield return new WaitForSeconds(6);
        }

    }
}
