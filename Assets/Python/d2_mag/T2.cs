using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2 : MonoBehaviour
{
    public GameObject tr;
    public GameObject tr2;
    public GameObject dooro;
    public GameObject pers;
    public GameObject pers2;
    public GameObject pers3;
    public GameObject pers4;
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
        Invoke(nameof(def), 2);
    }
     
    void def()
    {
        Destroy(pers);
        pers2.active = true;
        dooro.active = false;
        doorc.active = true;
        Invoke(nameof(def22), 5);
    }

    void def22()
    {
        pers3.active = true;
        Destroy(pers2);
        Invoke(nameof(def2), 2);
    }
    void def2()
    {
        Destroy(pers3);
        pers4.active = true;
    }
}
