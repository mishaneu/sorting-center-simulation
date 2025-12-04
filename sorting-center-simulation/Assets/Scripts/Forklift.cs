using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forklift : MonoBehaviour
{
    public Transform target;
    private GameObject player;
    private bool inCar = false;
    public Transform targetExit;
    public Animator StartCar;
    void Update()
    {
        if (inCar)
        {
            player.transform.position = target.position;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            if (Input.GetKeyDown(KeyCode.X))
            {
                player = other.gameObject;
                inCar = true;
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                inCar = false;
                player.transform.position = targetExit.position;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                StartCar.SetTrigger("Go");
            }
        }
    }
}
