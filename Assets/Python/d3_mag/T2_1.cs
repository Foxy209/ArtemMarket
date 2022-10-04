using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2_1 : MonoBehaviour
{
    public GameObject pel1;
    public GameObject pel2;
    public GameObject d_o;
    public GameObject d_c;

    private void Update()
    {
        Invoke(nameof(qq), 1);
    }

    void qq()
    {
        pel1.active = true;
        d_o.active = true;
        d_c.active = false;
        Invoke(nameof(qs), 2);
    }

    void qs()
    {
        d_o.active = false;
        d_c.active = true;
        Invoke(nameof(wd), 4);
    }

    void wd()
    {
        Destroy(pel1);
        pel2.active = true;
    }
}
