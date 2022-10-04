using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TT3_1 : MonoBehaviour
{
    public int fdd;
    public Text txt;
    public GameObject per;
    public GameObject per1;
    public GameObject per2;
    public GameObject per3;
    public GameObject stena;
    public GameObject pl;
    public GameObject t4;
    public GameObject door1;
    public GameObject door2;
    public GameObject door_;
    public GameObject Cam;
    public AudioSource s;

    private void Update()
    {
        Up();
        if (Cam.active == true)
        {
            txt.text = "Space= drop the product  F=roll           In total=" + fdd.ToString();   
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "box")
        {
            fdd++;
            s.Play();
        }

        if (fdd == 25)
        {
            aaa();
        }
    }

    void Up()
    {
        Destroy(per);
        per1.active = true;
        stena.active = true;
        Invoke(nameof(sa), 5);
    }

    void sa()
    {
        Destroy(per1);
        per2.active = true;
        stena.active = false;
    }

    void aaa()
    {
        Destroy(per2);
        Cam.active = false;
        txt.text = "";
        per3.active = true;
        pl.active = true;
        t4.active = true;
        Invoke(nameof(fss), 5);
    }

    void fss()
    {
        door1.active = true;
        door_.active = false;
        door2.active = false;
        Invoke(nameof(fv), 2);
    }

    void fv()
    {
        Destroy(door2);
        Destroy(per3);
        Destroy(door1);
        door_.active = true;
    }
    
}
