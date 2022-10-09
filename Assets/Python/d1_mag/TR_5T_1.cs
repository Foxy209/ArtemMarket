using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_5T_1 : MonoBehaviour
{
    public GameObject light;
    public GameObject spot;
    public GameObject tr;
    public GameObject tr2;
    public GameObject pl;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            light.active = false;
            tr2.active = true;
            spot.active = true;
            Destroy(pl);
            Destroy(tr);
        }
    }
}
