using UnityEngine;
using System.Collections;

public class DeactiveMessageBox : MonoBehaviour {

	public void DeactiveBox()
    {
        transform.gameObject.SetActive(false);
    }

    public void ButtonCloseMessage()
    {
        Modules.PlayAudioClipFree(Modules.audioButton);
        transform.gameObject.GetComponent<Animator>().SetTrigger("TriClose");
    }

    public void PlayAudioShow()
    {
        Modules.PlayAudioClipFree(Modules.audioShowMessage);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (transform.gameObject.activeSelf)
                ButtonCloseMessage();
        }
    }
}