using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    Transform[] Spawns;
    public float spawnInterval;
    public GameObject zombiePrefab;
    private float timer;
    bool active = true;

    void Start()
    {
        Spawns = new Transform[transform.childCount];
        //we give the array a length of item.childcount

        for (int i = 0; i < transform.childCount; i++)
        {
            Spawns[i] = transform.GetChild(i).transform;
        }

        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(active)
        {
            timer += Time.deltaTime;
            if(timer >= spawnInterval)
            {
                int i = Random.Range(0, transform.childCount);
                Instantiate(zombiePrefab, Spawns[i].position, Spawns[i].rotation);

                yield return new WaitForSeconds(spawnInterval);
                timer = 0;
                spawnInterval += Mathf.Sqrt(timer);
            }
        }
    }

    public IEnumerator WaitFrames(int amount) // taken from the "waitfor.cs" script, allows us to wait for a given amount of frames.
    {
        yield return StartCoroutine(WaitFor.Frames(amount));
    }
}
