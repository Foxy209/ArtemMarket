using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T3_1 : MonoBehaviour
{
    public GameObject pepl;
    public GameObject pepl1;
    public GameObject pepl2;
    public GameObject pepl22;
    public GameObject pepl11;
    public GameObject te;

    private void Update()
    { 
        Destroy(pepl);
        pepl1.active = true;
        pepl2.active = true;
        te.active = true;
        Invoke(nameof(ed), 7);
    }

    void ed()
    {
        Destroy(pepl1);
        pepl11.active = true;
        Invoke(nameof(edd), 9);
    }

    void edd()
    {
        Destroy(pepl2);
        pepl22.active = true;
    }
}
