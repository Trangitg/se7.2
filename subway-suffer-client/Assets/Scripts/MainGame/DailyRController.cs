using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class DailyRController : MonoBehaviour {

    public GameObject messageBox;
    private const string lastRewardClaimKey = "LastRewardClaimTime";
    private TimeSpan rewardInterval = TimeSpan.FromHours(24);
    public GameObject ClaimCoinButton;
    public GameObject AfterClaim;
    public Text textTitle;
    public void StartShowMessage()
    {
        //xu ly ngon ngu
        int iLang = Modules.indexLanguage;
        textTitle.font = AllLanguages.listFontLangA[iLang];
        textTitle.text = AllLanguages.menuDailyReward[iLang];
    }

    public void ButtonCloseClick()
    {
        Modules.PlayAudioClipFree(Modules.audioButton);
        messageBox.GetComponent<Animator>().SetTrigger("TriClose");
    }
    public void ClaimReward() {
        string lastRewardClaimTimeString = PlayerPrefs.GetString(lastRewardClaimKey, string.Empty);
        if (string.IsNullOrEmpty(lastRewardClaimTimeString) || 
        (DateTime.Now - DateTime.Parse(lastRewardClaimTimeString) >= rewardInterval)) {
            ButtonClaimClick();
            UpdateLastRewardClaimTime();
        }
    }

    public void UpdateLastRewardClaimTime() {
        PlayerPrefs.SetString(lastRewardClaimKey, DateTime.Now.ToString());
    }


    public void ButtonClaimClick() {
        Modules.totalCoin += 500;
        Modules.SaveCoin();
        AfterClaim.SetActive(true);
    }
    
}

