using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_2T_1 : MonoBehaviour
{
    public GameObject Tocka;
    public GameObject tr;
    public GameObject tr2;
    public GameObject korob;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tr2.active = true;
            Tocka.active = false;
            korob.active = true;
            Destroy(tr);
        }
    }
}
