using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TR_2T_3 : MonoBehaviour
{
    public GameObject tr;
    public GameObject tr2;
    public GameObject pers;
    public GameObject pers2;
    public GameObject pers3;
    public GameObject pers4;
    public GameObject pers5;
    public GameObject dooro;
    public GameObject doorc;
    public GameObject box;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "box")
        {
            tr.active = true;
            tr2.active = false;
            pres();
            box.active = false;
            box2.active = false;
            box3.active = false;
            box4.active = false;
        }
    }

    void pres()
    {
        pers.active = true;
        dooro.active = true;
        doorc.active = false;
        Invoke(nameof(dor), 3);
    }

    void dor()
    {
        dooro.active = false;
        doorc.active = true;
        pers2.active = true;
        Destroy(pers);
        Invoke(nameof(pres2), 3);
    }

    void pres2()
    {
        Destroy(pers2);
        pers3.active = true;
        Invoke(nameof(pres3), 2);
    }

    void pres3()
    {
        Destroy(pers3);
        pers4.active = true;
        Invoke(nameof(pres4), 2);
    }
    void pres4()
    {
        Destroy(pers4);
        pers5.active = true;
    }
}
