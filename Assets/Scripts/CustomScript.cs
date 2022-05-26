using Antilatency.DeviceNetwork;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class CustomScript : Antilatency.SDK.AltTrackingUsbSocket
{
    protected override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeTrackerColor();
        }
    }

    private void ChangeTrackerColor()
    {
        var nativeNetwork = Network.NativeNetwork;
        NodeHandle[] nodes = nativeNetwork.getNodes();
        foreach (NodeHandle node in nodes)
        {
            if (nativeNetwork.nodeGetStringProperty(node, "sys/HardwareName") == "Alt")
            {
                Debug.Log("Trying to change Node: " + nativeNetwork.nodeGetStringProperty(node, "sys/HardwareName"));
                nativeNetwork.nodeStartPropertyTask(node).setStringProperty("usr/LED/Color", "FFA500");
            }
        }
    }
}
