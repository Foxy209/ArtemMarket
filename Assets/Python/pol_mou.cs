using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.Examples;

public class pol_mou : MonoBehaviour
{
    [SerializeField] private int _notes;
    [SerializeField] private Transform _eyes;
    private int Pringlse = 0;
    public GameObject t;
    public GameObject tvgrgg;
    public GameObject light;
    public GameObject light2;
    public AudioSource s;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(_eyes.position, _eyes.forward, out hit, 3f))
            {
                if (hit.collider.gameObject.name.Contains("Note"))
                {
                    _notes++;
                    s.Play();
                    Destroy(hit.collider.gameObject);
                }
                print(hit.collider.gameObject.name);
            }
        }

        if (_notes == 2)
        {
            wsw();
        }
        
        
        if (_notes == 4)
        {
            t.active = true;
            tvgrgg.active = true;
        }
    }

    void wsw()
    {
        Destroy(light);
        Invoke(nameof(ed), 2);
    }
    void ed()
    {
        light2.active = true;
    }
}