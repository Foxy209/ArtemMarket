using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class windoes_wash : MonoBehaviour
{
    [SerializeField] private int _notes;
    [SerializeField] private Transform _eyes;
    private int Pringlse = 0;
    public AudioSource s;
    public GameObject t;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(_eyes.position, _eyes.forward, out hit, 5f))
            {
                if (hit.collider.gameObject.name.Contains("was"))
                {
                    _notes++;
                    s.Play();
                    Destroy(hit.collider.gameObject);
                }
                print(hit.collider.gameObject.name);
            }
        }
        if (_notes == 3)
        {
            t.active = true;
        }
    }
}
