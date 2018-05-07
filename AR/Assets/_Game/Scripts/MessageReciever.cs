using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageReciever : MonoBehaviour {

    private Text m_TextBox;

    private void Start()
    {
        m_TextBox = GetComponent<Text>();
    }

    private void OnEnable()
    {
        CubeTrackableEventHandler.OnSendMessage += DisplyMessage;
    }

    private void OnDisable()
    {
        CubeTrackableEventHandler.OnSendMessage -= DisplyMessage;
    }

    private void DisplyMessage(string message)
    {
        m_TextBox.text = message;
    }

}
