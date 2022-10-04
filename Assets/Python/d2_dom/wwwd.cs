using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class wwwd : MonoBehaviour
{
    public GameObject bl;
    public GameObject aud;
    public GameObject pl;
    public GameObject tr;
    public GameObject tr2;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            bl.active = true;
            aud.active = true;
            Invoke(nameof(fd), 3);
        }
    }

    void fd()
    {
        aud.active = false;
        tr2.active = true;
        Destroy(tr);
    }
}
