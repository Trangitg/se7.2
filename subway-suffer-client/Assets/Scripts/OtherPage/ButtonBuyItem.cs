using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonBuyItem : MonoBehaviour {

    public int codeItem = 0;//0 coin, 1 key, 2 skis, 3 mystery, 4 headStart, 5 scoreBooster
    public Text textCost, textNote, textCoin;
    public Color colorNotCoin = Color.red;
    private Color originColorNote = Color.white;

    void Start()
    {
        originColorNote = textNote.color;
    }

    public void ButtonClick()
    {
        textNote.font = AllLanguages.listFontLangB[Modules.indexLanguage];
        Modules.PlayAudioClipFree(Modules.audioButton);
        if (codeItem == 0)//coin (xu ly in app purchase)
        {
            //print("Buy coin");
            Purchaser.Instance.BuyProductID(Modules.listProductID[0]);
        }
        else if (codeItem == 1)//key (xu ly in app purchase)
        {
            //print("Buy key");
            int cost = Modules.IntParseFast(textCost.text); //lấy giá tiền vật phẩm từ text textCost chuyển thành kiểu int để tính toán
            if (Modules.totalCoin >= cost)//Nếu đủ tiền
            {
                if (Modules.totalKey < 10000) // Đặt giới hạn số chìa khóa là 10000, nếu số chìa khóa đang có < 10000
                {
                    Modules.totalKey += 1;//số chìa khóa +1
                    Modules.SaveKey();
                    Modules.totalCoin -= cost;//Trừ số tiền hiện tại bằng giá tiền mua
                    Modules.SaveCoin();

                    if (Modules.containShopItem.activeSelf)
                        Camera.main.GetComponent<PageShopItems>().UpdateCoins();
                        textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalKey.ToString();           
                    if (Modules.containShopItem.activeSelf)
                        Camera.main.GetComponent<PageShopItems>().UpdateKeys();
           // Cập nhật số tiền và số key hiện có trong Pageshop 
                }
                else//nếu vượt quá số lượng key giới hạn thì phần textNote in ra thông báo lỗi shopMaxNumber
                {
                    textNote.text = AllLanguages.shopMaxNumber[Modules.indexLanguage];
                    textNote.color = colorNotCoin;
                    Invoke("ReturnValueTotal", 1f);
                }
            }
            else//Nếu không đủ tiền thì phần textNote in ra thông báo lỗi shopNotEnough
            {
                textNote.text = AllLanguages.shopNotEnough[Modules.indexLanguage];
                textNote.color = colorNotCoin;
                Invoke("ReturnValueTotal", 1f);
            }
        }
        else if (codeItem == 2)//neu la skis
        {
            int cost = Modules.IntParseFast(textCost.text);
            if (Modules.totalCoin >= cost)//neu du tien
            {
                if (Modules.totalSkis < Modules.maxHoverboard)
                {
                    Modules.totalSkis++;
                    Modules.totalCoin -= cost;
                    Modules.SaveCoin();
                    textCoin.text = Modules.totalCoin.ToString();
                    Modules.SaveSkis();
                    textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalSkis.ToString();
                }
                else
                {
                    textNote.text = AllLanguages.shopMaxNumber[Modules.indexLanguage];
                    textNote.color = colorNotCoin;
                    Invoke("ReturnValueTotal", 1f);
                }
            }
            else//neu khong du tien
            {
                textNote.text = AllLanguages.shopNotEnough[Modules.indexLanguage];
                textNote.color = colorNotCoin;
                Invoke("ReturnValueTotal", 1f);
            }
        }
        else if (codeItem == 3)//neu la mystery
        {
            int cost = Modules.IntParseFast(textCost.text);
            if (Modules.totalCoin >= cost)//neu du tien
            {
                Modules.totalCoin -= cost;
                Modules.SaveCoin();
                textCoin.text = Modules.totalCoin.ToString();
                Modules.nextPageOpenBox = "ShopItems";
                Modules.containOpenBox.SetActive(true);
                Modules.containShopItem.SetActive(false);
                Modules.containOpenBox.transform.Find("MainCamera").GetComponent<PageOpenMysteryBox>().CallStart();
            }
            else//neu khong du tien
            {
                textNote.text = AllLanguages.shopNotEnough[Modules.indexLanguage];
                textNote.color = colorNotCoin;
                Invoke("ReturnValueTotal", 1f);
            }
        }
        else if (codeItem == 4)//neu la headStart
        {
            int cost = Modules.IntParseFast(textCost.text);
            if (Modules.totalCoin >= cost)//neu du tien
            {
                if (Modules.totalHeadStart < Modules.maxHeadstart)
                {
                    Modules.totalHeadStart++;
                    Modules.totalCoin -= cost;
                    Modules.SaveCoin();
                    textCoin.text = Modules.totalCoin.ToString();
                    Modules.SaveHeadStart();
                    textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalHeadStart.ToString();
                }
                else
                {
                    textNote.text = AllLanguages.shopMaxNumber[Modules.indexLanguage];
                    textNote.color = colorNotCoin;
                    Invoke("ReturnValueTotal", 1f);
                }
            }
            else//neu khong du tien
            {
                textNote.text = AllLanguages.shopNotEnough[Modules.indexLanguage];
                textNote.color = colorNotCoin;
                Invoke("ReturnValueTotal", 1f);
            }
        }
        else if (codeItem == 5)//neu la scoreBooster
        {
            int cost = Modules.IntParseFast(textCost.text);
            if (Modules.totalCoin >= cost)//neu du tien
            {
                if (Modules.totalScoreBooster < Modules.maxScorebooster)
                {
                    Modules.totalScoreBooster++;
                    Modules.totalCoin -= cost;
                    Modules.SaveCoin();
                    textCoin.text = Modules.totalCoin.ToString();
                    Modules.SaveScoreBooster();
                    textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalScoreBooster.ToString();
                }
                else
                {
                    textNote.text = AllLanguages.shopMaxNumber[Modules.indexLanguage];
                    textNote.color = colorNotCoin;
                    Invoke("ReturnValueTotal", 1f);
                }
            }
            else//neu khong du tien
            {
                textNote.text = AllLanguages.shopNotEnough[Modules.indexLanguage];
                textNote.color = colorNotCoin;
                Invoke("ReturnValueTotal", 1f);
            }
        }
    }

    void ReturnValueTotal()
    {
        if (codeItem == 0)//coin (xu ly in app purchase)
            textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalCoin.ToString();
        else if (codeItem == 1)//key (xu ly in app purchase)
            textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalKey.ToString();
        else if (codeItem == 2)//neu la skis
            textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalSkis.ToString();
        else if (codeItem == 3)//neu la mystery
            textNote.text = AllLanguages.shopUseRight[Modules.indexLanguage];
        else if (codeItem == 4)//neu la headStart
            textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalHeadStart.ToString();
        else if (codeItem == 5)//neu la scoreBooster
            textNote.text = AllLanguages.shopTotal[Modules.indexLanguage] + " " + Modules.totalScoreBooster.ToString();
        textNote.color = originColorNote;
    }
}
