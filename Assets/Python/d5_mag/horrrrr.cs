using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horrrrr : MonoBehaviour
{
    public GameObject pr1;
    public GameObject pr2;

    private void Update()
    {
        Invoke(nameof(gfe), 2);
    }

    void gfe()
    {
        Destroy(pr1);
        pr2.active = true;
    }
}
