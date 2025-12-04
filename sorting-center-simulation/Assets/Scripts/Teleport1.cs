using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    public Transform point2;
    public Renderer Teleport;
    private bool isReadyToTeleport = true;
    [NonSerialized]
    public bool isPoint1;
    public Teleport2 checker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isReadyToTeleport)
        {
            other.transform.position = point2.transform.position;
            isReadyToTeleport = false;
            isPoint1 = false;
            checker.isPoint2 = true;
            Teleport.material.color = new Color32(255, 0, 0, 1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isPoint1)
        {
            isReadyToTeleport = true;
            Teleport.material.color = new Color32(0, 255, 0, 1);
        }
    }
}

