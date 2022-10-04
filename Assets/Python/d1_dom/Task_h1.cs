using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Task_h1 : MonoBehaviour
{
    //public GameObject checkpount;
    [SerializeField] private Text task;
    public GameObject one;
    void aaa()
    {
        one.active = false;
    }
    private void Update()
    {
        Invoke(nameof(aaa), 6);
        task.text = "Go to work".ToString();
    }
}
