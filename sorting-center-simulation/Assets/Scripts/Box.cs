using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Catch checker;
    public TextMeshProUGUI text2;
    private int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            checker.isCatch = false;
            count++;
            text2.text = count.ToString();
            Destroy(other.gameObject);
        }
    }
}
