using Antilatency.DeviceNetwork;
using Antilatency.SDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public DeviceNetwork Network;

    private void Update()
    {
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
