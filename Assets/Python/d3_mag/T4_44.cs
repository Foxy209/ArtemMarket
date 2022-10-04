using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class T4_44 : MonoBehaviour
{
    public GameObject car;
    public GameObject pep;
    public GameObject tr;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            EFE();    
        }
    }

    void EFE()
    {
        car.active = true;
        Invoke(nameof(dw), 3);
    }

    void dw()
    {
        Destroy(pep);
        Invoke(nameof(efde), 3);
    }

    void efde()
    {
        Destroy(car);
        Destroy(tr);
    }
}
