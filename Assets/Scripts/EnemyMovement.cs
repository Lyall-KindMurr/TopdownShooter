using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        if (!player)
        {
            Debug.Log("No player tag found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
    }
}
