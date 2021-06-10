using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, (1 << LayerMask.NameToLayer("Floor")))) // I tried to make collision only work on the floor layer.
            {
                Debug.Log("hit: " + hit.collider.tag);
                if (hit.collider.tag == "PlayArea")
                {
                    agent.destination = hit.point;
                }
            }
        }
    }
}
