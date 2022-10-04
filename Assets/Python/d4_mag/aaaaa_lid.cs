using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaaa_lid : MonoBehaviour
{
    public GameObject tr;
    public GameObject tr2;
    public GameObject shab;
    public GameObject shab2;
    public GameObject pep;
    public GameObject pep2;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            shab2.active = true;
            pep2.active = true;
            tr2.active = true;
            shab.active = false;
            pep.active = false;
            Destroy(tr);
        }
    }
}
