using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vvbvbvb : MonoBehaviour
{
    public GameObject can;
    public GameObject epp;

    private void Update()
    {
        Invoke(nameof(ff), 2);
    }

    void ff()
    {
        can.active = true;
        Destroy(epp);
    }
}
