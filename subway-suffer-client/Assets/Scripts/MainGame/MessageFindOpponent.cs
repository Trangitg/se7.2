using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Photon.Pun;
using Photon.Realtime;


public class MessageFindOpponent : MonoBehaviour {

    public Image myAvatar, enemyAvatar;
    public GameObject iconLoading;
    public GameObject numLoading;
    private bool randomRoom = false;
    private int countTime = 3;
    [HideInInspector]
    public bool isClose = false;

    public void CallStart()
    {
        PlayerPrefs.DeleteKey("PUNCloudBestRegion");
        if (!PhotonNetwork.IsConnected)
            PhotonNetwork.ConnectUsingSettings();
        Modules.fbEnemyAvatar = null;
        myAvatar.sprite = Modules.fbMyAvatar;
        if (myAvatar.sprite == null) myAvatar.sprite = Modules.iconAvatarNull;
        UpdateAvatarEnemy();
        iconLoading.SetActive(true);
        numLoading.SetActive(false);
        randomRoom = false;
        isClose = false;
        countTime = 3;
        CheckRooms();
	}

    void CheckRooms()
    {
        if (PhotonNetwork.InRoom)
        {
            if (PhotonNetwork.CurrentRoom.PlayerCount == 2)//neu du nguoi thi vao choi
            {
                Modules.networkManager.GetComponent<NetworkMagnager>().SyncAvatar();
                iconLoading.SetActive(false);
                numLoading.SetActive(true);
                numLoading.GetComponent<Text>().text = countTime.ToString();
                Invoke("RunCountTime", 1);
            }
            else Invoke("CheckRooms", 1);
        }
        else
        {
            if (PhotonNetwork.InLobby)
            {
                if (!randomRoom)
                {
                    PhotonNetwork.JoinRandomRoom();
                    randomRoom = true;
                }
            }
            Invoke("CheckRooms", 1);
        }
    }

    void OnPhotonRandomJoinFailed()
    {
        if (isClose) return;
        PhotonNetwork.CreateRoom(null, new RoomOptions() { MaxPlayers = 2 }, Photon.Realtime.TypedLobby.Default);
    }

    void RunCountTime()
    {
        countTime--;
        numLoading.GetComponent<Text>().text = countTime.ToString();
        if (countTime > 0)
            Invoke("RunCountTime", 1);
        else
        {
            CancelInvoke();
            Modules.networkManager.GetComponent<NetworkMagnager>().StartGame();
        }
    }

    public void UpdateAvatarEnemy()
    {
        enemyAvatar.sprite = Modules.fbEnemyAvatar;
        if (enemyAvatar.sprite == null) enemyAvatar.sprite = Modules.iconAvatarNull;
    }

    public void ButtonCloseBox()
    {
        CancelInvoke();
        transform.GetComponent<Animator>().SetTrigger("TriClose");
        if (PhotonNetwork.InRoom) Modules.networkManager.GetComponent<NetworkMagnager>().CancelRoom();
        Modules.PlayAudioClipFree(Modules.audioButton);
        isClose = true;
    }
}