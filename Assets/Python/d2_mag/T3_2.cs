using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T3_2 : MonoBehaviour
{
    public int fd;
    public Text txt;
    public GameObject per;
    public GameObject stena;
    public GameObject pl;
    public GameObject t4;
    public GameObject door1;
    public GameObject door2;
    public GameObject door22;
    public GameObject door_;
    public GameObject Cam;
    public GameObject Cum;
    public GameObject pl1;
    public GameObject pl11;
    public GameObject pl2;
    public GameObject pl22;
    public GameObject pl222;
    public GameObject pl2222;
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

        if (fd == 5)
        {
            aaa();
        }

        if (fd == 9)
        {
            aaa2();
        }
    }

    void aaa()
    {
        Destroy(pl1);
        pl11.active = true;
        stena.active = true;
        door_.active = false;
        Invoke(nameof(ad), 2);
    }

    void ad()
    {
        Destroy(pl2);
        pl22.active = true;
        Destroy(stena);
        Invoke(nameof(aw), 1);
    }

    void aw()
    {
       Destroy(pl22);
       pl222.active = true;
       Invoke(nameof(add), 1);
    }

    void add()
    {
        door1.active = false;
        door2.active = true;
        Invoke(nameof(addd), 2);
    }

    void addd()
    {
        Destroy(pl11);
        door1.active = true;
        Destroy(door2);
    }

    void aaa2()
    {
        Destroy(pl222);
        pl2222.active = true;
        Cam.active = false;
        pl.active = true;
        per.active = true;
        Destroy(Cum);
        txt.text = "";
        Invoke(nameof(aaaq), 4);
    }

    void aaaq()
    {
        Destroy(door1);
        door22.active = true;
        Invoke(nameof(wdw), 2);
    }

    void wdw()
    {
        Destroy(door22);
        door_.active = true;
        Destroy(pl2222);
    }
}
