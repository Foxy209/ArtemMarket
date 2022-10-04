using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optimuzet2 : MonoBehaviour
{
    public GameObject predmetu;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            predmetu.active = true;
        }
    }
}
