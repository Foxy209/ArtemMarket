using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Transform Player;
    private UnityEngine.AI.NavMeshAgent NMA;



    void Start () {
        Player = GameObject.FindGameObjectWithTag("Finish").transform;
        NMA = (UnityEngine.AI.NavMeshAgent)this.GetComponent("NavMeshAgent");
    }
	
	
    void Update () {
        NMA.SetDestination(Player.position);

    

    }
}
