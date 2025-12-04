using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateZoneTrigger : MonoBehaviour
{
    public Table checker;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            checker.isCreateDetail = false;
        }
    }
}
