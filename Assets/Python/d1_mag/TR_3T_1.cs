using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_3T_1 : MonoBehaviour
{
    public GameObject pepl;
    public GameObject pep2;
    public GameObject pep3;
    public GameObject pep4;
    public GameObject pep5;
    public GameObject npep;
    public GameObject tr;

    void Update()
    {
        Destroy(pepl);
        npep.active = true;
        pep5.active = true;
        tr.active = true;
        Invoke(nameof(ssd), 2);
    }

    void ssd()
    {
        pep2.active = true;
        Destroy(npep);
        Invoke(nameof(ssdd), 2);
    }

    void ssdd()
    {
        pep3.active = true;
        Destroy(pep2);
        Invoke(nameof(ssddd), 1);
    }

    void ssddd()
    {
        pep4.active = true;
        Destroy(pep5);
    }
}
