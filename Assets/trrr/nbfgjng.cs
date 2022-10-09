using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nbfgjng : MonoBehaviour
{
    public GameObject ol1;
    public GameObject ol2;
    public GameObject ll;
    public GameObject ll2;

    private void Update()
    {
        Invoke(nameof(hg), 7);
    }
    void hg()
    {
        Destroy(ol1);
        ol2.active = true;
        Destroy(ll);
        Invoke(nameof(ff), 1);
    }

    void ff()
    {
        ll2.active = true;
    }
}
