using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CubeTrackableEventHandler : DefaultTrackableEventHandler {

    //Used to override the default eventhandler
    protected override void OnTrackingFound()
    {
        Debug.Log("Hej");


        //All of the original method
        base.OnTrackingFound();
    }

    //Used to override the default eventhandler
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }
}
