using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class T2_4 : MonoBehaviour
{
    public GameObject pl;
    public GameObject b;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject dorO;
    public GameObject dorC;
    public GameObject dwd;

    private void Update()
    {
        Destroy(b);
        b2.active = true;
        Invoke(nameof(f), 6);
    }

    void f()
    {
        pl.active = true;
        b3.active = true;
        dwd.active = true;
        Destroy(b2);
        Invoke(nameof(f2), 6);
    }

    void f2()
    {
        dorO.active = true;
        dorC.active = false;
        Invoke(nameof(f3), 2);
    }

    void f3()
    {
        dorO.active = false;
        dorC.active = true;
        Invoke(nameof(f4), 8);
    }

    void f4()
    {
        Destroy(b3);
        b4.active = true;

    }
}
