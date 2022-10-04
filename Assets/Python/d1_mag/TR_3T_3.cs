using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_3T_3 : MonoBehaviour
{
    public GameObject cum;
    public GameObject tr;
    public GameObject pl;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            cum.active = true;
            pl.active = false;
            Destroy(tr);
        }
    }
}
