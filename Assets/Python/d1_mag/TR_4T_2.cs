using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TR_4T_2 : MonoBehaviour
{
    public GameObject sh;
    public GameObject sh2;
    public GameObject tr;
    public GameObject ta5;
    public GameObject ta4;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            sh.active = true;
            tr.active = false;
            ta5.active = true;
            Destroy(sh2);
            Destroy(ta4);
        }
    }
}
