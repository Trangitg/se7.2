using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageAutoFindOpponent : MonoBehaviour {
    
    //xu ly ngon ngu
    public Text textTitle, textNote, textButton;

    public void StartShowMessage()
    {
        //xu ly ngon ngu
        int iLang = Modules.indexLanguage;
        textTitle.font = AllLanguages.listFontLangA[iLang];
        textTitle.text = AllLanguages.menuRate[iLang];
        textNote.font = AllLanguages.listFontLangB[iLang];
        textNote.text = AllLanguages.menuNoteRate[iLang];
        textButton.font = AllLanguages.listFontLangA[iLang];
        textButton.text = AllLanguages.menuButtonRate[iLang];
    }

    public void ButtonCloseClick()
    {
        transform.gameObject.GetComponent<Animator>().SetTrigger("TriClose");
        Modules.PlayAudioClipFree(Modules.audioButton);
    }
}