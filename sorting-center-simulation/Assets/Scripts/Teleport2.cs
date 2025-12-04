using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public Renderer Teleport;
    private bool isReadyToTeleport = false;
    public Transform point1;
    public Teleport1 checker;
    [NonSerialized]
    public bool isPoint2;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isPoint2)
        {
            Teleport.material.color = new Color32(0, 255, 0, 1);
            isReadyToTeleport = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isReadyToTeleport)
        {
            other.transform.position = point1.transform.position;
            isReadyToTeleport = false;
            checker.isPoint1 = true;
            isPoint2 = false;
            Teleport.material.color = new Color32(255, 0, 0, 1);
        }
    }
}
