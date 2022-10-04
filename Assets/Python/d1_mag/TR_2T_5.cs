using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_2T_5 : MonoBehaviour
{
    public GameObject tr;
    public GameObject tr2;
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
            box.active = false;
            box2.active = false;
            box3.active = false;
            box4.active = false;
        }

    }
}
