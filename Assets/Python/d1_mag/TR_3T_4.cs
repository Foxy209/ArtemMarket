using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TR_3T_4 : MonoBehaviour
{
    public int fd;
    public Text txt;
    public GameObject per;
    public GameObject stena;
    public GameObject per_;
    public GameObject per__;
    public GameObject per___;
    public GameObject per1;
    public GameObject per2;
    public GameObject per3;
    public GameObject per11;
    public GameObject per22;
    public GameObject ddw;
    public GameObject pl;
    public GameObject t4;
    public GameObject door1;
    public GameObject door2;
    public GameObject door22;
    public GameObject door_;
    public GameObject Cam;
    public GameObject Cum;
    public AudioSource s;

    private void Update()
    {
        if (Cam.active == true)
        {
            txt.text = "Space= drop the product  F=roll           In total=" + fd;   
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "box")
        {
            fd++;
            s.Play();
        }

        if (fd == 10)
        {
            aaa();
        }
        
        if (fd == 15)
        {
            aaa2();
        }
    }
    
    void wd()
    {
        per__.active = true;
        Destroy(per_);
        Invoke(nameof(wwd), 1);
    }

    void wwd()
    {
        Destroy(per__);
        stena.active = false;
        per___.active = true;
    }
    void aaa2()
    {
        per11.active = true;
        pl.active = true;
        t4.active = true;
        Destroy(Cum);
        Destroy(txt);
        ddw.active = false;
        Destroy(per___);
        Invoke(nameof(asd2), 3);
    }

    void asd2()
    {
        Destroy(per11);
        per22.active = true;
        door1.active = false;
        door22.active = true;
        Invoke(nameof(saa2), 3);
    }

    void saa2()
    {
        door1.active = true; 
        Destroy(door22);
        Destroy(per22);
    }
    void aaa()
    {
        per1.active = true;
        stena.active = true;
        Destroy(per);
        Destroy(door_);
        Invoke(nameof(asw), 2);
    }
    void asw()
    {
        per2.active = true;
        Destroy(per1);
        Invoke(nameof(asd), 4);
    }

    void asd()
    {
        Destroy(per2);
        per3.active = true;
        door1.active = false;
        door2.active = true;
        Invoke(nameof(saa), 3);
    }

    void saa()
    {
        door1.active = true;
        Destroy(per3);
        Destroy(door2);
        Invoke(nameof(wd), 2);
    }
}
