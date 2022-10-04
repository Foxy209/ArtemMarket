using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peplllll : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p12;
    public GameObject p22;
    public GameObject p32;
    public GameObject p42;

    private void Update()
    {
        dwe();
    }

    void dwe()
    {
        p1.active = true;
        p2.active = true;
        p3.active = true;
        p4.active = true;
        Invoke(nameof(dw), 5);
    }

    void dw()
    {
        Destroy(p1);
        p12.active = true;
        Invoke(nameof(dww), 5);
    }

    void dww()
    {
        Destroy(p2);
        p22.active = true;
        Invoke(nameof(wd), 1);
    }

    void wd()
    {
        Destroy(p3);
        p32.active = true;
        Destroy(p4);
        p42.active = true;
    }
}