using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DailyReward : MonoBehaviour {

    public GameObject messageBox, parentContent;
    public Text textValueText;
    public Image imageButApplyCancel;
    public Color colorApply, colorCancel;
    public float requestTime = 0.1f;
    public float maxTime = 10f;//cho phep thuc hien toi da 10 giay
    //xu ly ngon ngu
    public Text textTitle, textInfo, textNote, textNoContent, textApplyCancel;

    public void UpdateLanguage()
    {
        //xu ly ngon ngu
        int iLang = Modules.indexLanguage;
        textTitle.font = AllLanguages.listFontLangA[iLang];
        textTitle.text = AllLanguages.menuChallenge[iLang];
        textInfo.font = AllLanguages.listFontLangB[iLang];
        textInfo.text = AllLanguages.menuTitleChallenge[iLang];
        textNote.font = AllLanguages.listFontLangB[iLang];
        textNote.text = AllLanguages.menuNoteChallenge[iLang];
        textNoContent.font = AllLanguages.listFontLangA[iLang];
        textNoContent.text = AllLanguages.menuNoChallenge[iLang];
        textApplyCancel.font = AllLanguages.listFontLangA[iLang];
        if (Modules.dataChallengeUse != "") textApplyCancel.text = AllLanguages.menuCancel[iLang];
        else textApplyCancel.text = AllLanguages.menuApply[iLang];
    }

    public void ButtonCloseClick()
    {
        Modules.SaveDataChallenge();
        Modules.PlayAudioClipFree(Modules.audioButton);
        messageBox.GetComponent<Animator>().SetTrigger("TriClose");
    }

    public void ButtonApplyCancelClick()
    {
        Modules.PlayAudioClipFree(Modules.audioButton);
        if (AllLanguages.menuCancel.Contains(textApplyCancel.text))
        {
            textApplyCancel.text = AllLanguages.menuApply[Modules.indexLanguage];
            imageButApplyCancel.color = colorApply;
            if (textNoContent.gameObject.activeSelf)
                ButtonCloseClick();
        }
    }
}
