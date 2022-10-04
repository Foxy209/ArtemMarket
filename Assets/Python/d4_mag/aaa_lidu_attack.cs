using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa_lidu_attack : MonoBehaviour
{
    public GameObject light;
    public GameObject pepl;
    public GameObject pep2;
    public GameObject tr;
    public GameObject t44;

    private void OnTriggerStay(Collider other)
    {
        Invoke(nameof(wfdwe), 1);
    }

    void wfdwe()
    {
        light.active = false;
        pepl.active = true;
        t44.active = true;
        pep2.active = false;
        Invoke(nameof(fe), 1);
    }

    void fe()
    {
        light.active = true;
        Destroy(tr);
    }
}
