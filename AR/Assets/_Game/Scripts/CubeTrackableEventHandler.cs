using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CubeTrackableEventHandler : DefaultTrackableEventHandler {

    public string m_FoundMessage;
    public string m_LostMessage;


    //Skapar och deklarerar eventet
    public delegate void MessageSender(string message);
    public static event MessageSender OnSendMessage;


    //Used to override the default eventhandler
    protected override void OnTrackingFound()
    {
        Debug.Log("Hej");


        //Base of the original method
        base.OnTrackingFound();
        if (OnSendMessage != null)
        {
            OnSendMessage(m_FoundMessage);
        }
    }

    //Used to override the default eventhandler
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (OnSendMessage != null)
        {
            OnSendMessage(m_LostMessage);
        }
        
    }
}
