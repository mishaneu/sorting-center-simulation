using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvStart : MonoBehaviour
{
    public Player checker;
    public float speed = 1.0f;
    [NonSerialized]
    public bool isMove = false;
    private GameObject item;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (isMove)
        {
            item.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            checker.isTakeItem = false;
            item = other.gameObject; 
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            isMove = true;
        }
    }
}
