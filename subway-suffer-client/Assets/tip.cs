using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipRandom : MonoBehaviour
{
    public int randNum;
    public GameObject tipDisplay;
    public bool genhint = false;

    void Update()
    {
        if (genhint == false){
        genhint = true;
        StartCoroutine(tipTracker());
        }
    }

    IEnumerator tipTracker(){
        while(true){
        randNum = Random.Range(1,4);
        if(randNum ==1){
            tipDisplay.GetComponentInChildren<Text>().text = " Remember to upgrade your items !";
        }
        if(randNum ==2){
            tipDisplay.GetComponentInChildren<Text>().text = " Daily rewards resets every 24 hours !";
        }
        if(randNum ==3){
            tipDisplay.GetComponentInChildren<Text>().text = " There are secret areas filled with treasures !";
        }
        if(randNum ==4){
            tipDisplay.GetComponentInChildren<Text>().text = " If you trip twice , the officer will catch up to you !";
        }
        tipDisplay.GetComponent<Animator>().Play("Tips");
        yield return new WaitForSeconds(6);
        genhint = false;
        }

    }
}
