using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    Transform[] Spawns;

    // Start is called before the first frame update
    void Start()
    {
        Spawns = new Transform[transform.childCount];
        //we give the array a length of item.childcount

        for (int i = 0; i < transform.childCount; i++)
        {
            Spawns[i] = transform.GetChild(i).transform;
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(Spawns[i].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
