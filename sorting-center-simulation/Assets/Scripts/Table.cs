using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Table : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public Renderer button_create;
    public Renderer button_cube;
    public Renderer button_sphere;
    public GameObject cube_detail;
    public GameObject sphere_detail;
    public Transform spawnpoint;
    private bool ready_to_create = false;
    private bool ready_to_create_mesh = false;
    private bool inZone = false;
    [NonSerialized]
    public bool isCreateDetail = false;
    public Player checker;
    public Transform CatchTrigger;
    [NonSerialized]
    public GameObject item;
    private void Start()
    {
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
    }
    private void Update()
    {
        if (inZone)
        {
            if (ready_to_create && !isCreateDetail)
            {
                if (Input.GetKey(KeyCode.C))
                {
                    text1.enabled = false;
                    text2.enabled = true;
                    button_create.material.color = new Color32(255, 0, 0, 1);
                    button_cube.material.color = new Color32(0, 255, 0, 1);
                    button_sphere.material.color = new Color32(0, 255, 0, 1);
                    ready_to_create_mesh = true;
                }
                if (ready_to_create_mesh)
                {
                    if (Input.GetKeyDown(KeyCode.L))
                    {
                        button_cube.material.color = new Color32(255, 1, 0, 1);
                        button_sphere.material.color = new Color32(255, 1, 0, 1);
                        item = Instantiate(cube_detail, spawnpoint.position, spawnpoint.rotation);
                        ready_to_create_mesh = false;
                        ready_to_create = false;
                        isCreateDetail = true;
                        text2.enabled = false;
                        text3.enabled = true;
                    }
                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        button_cube.material.color = new Color32(255, 1, 0, 1);
                        button_sphere.material.color = new Color32(255, 1, 0, 1);
                        item = Instantiate(sphere_detail, spawnpoint.position, spawnpoint.rotation);
                        ready_to_create_mesh = false;
                        ready_to_create = false;
                        isCreateDetail = true;
                        text2.enabled = false;
                        text3.enabled = true;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.E) && !ready_to_create)
            {
                checker.isTakeItem = true;
                isCreateDetail = false;
            }
        }
        if (checker.isTakeItem)
        {
            item.transform.position = CatchTrigger.transform.position;
            item.transform.rotation = CatchTrigger.transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isCreateDetail)
            {
                text3.enabled = true;
            }
            else
            {
                ready_to_create = true;
                text1.enabled = true;
                inZone = true;
                button_create.material.color = new Color32(0, 255, 0, 1);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text1.enabled = false;
            text3.enabled = false;
            text2.enabled = false;
            inZone = false;
        }
    }
}
