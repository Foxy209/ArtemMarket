using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_horr : MonoBehaviour
{
    [SerializeField] private int _notes;
    [SerializeField] private int _notes2;
    [SerializeField] private Transform _eyes;
    private int Pringlse = 0;
    public AudioSource s;
    public GameObject t;
    public GameObject H;

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
                if (hit.collider.gameObject.name.Contains("wasH"))
                {
                    _notes2++;
                    s.Play();
                    Destroy(hit.collider.gameObject);
                }
                print(hit.collider.gameObject.name);
            }
        }
        if (_notes2 == 1)
        {
            H.active = true;
            _notes++;
            _notes2 = 0;
        }
        if (_notes == 7)
        {
            t.active = true;
        }
    }
}
