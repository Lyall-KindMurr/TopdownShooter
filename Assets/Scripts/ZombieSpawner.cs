using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    Transform[] Spawns;
    int i = 0;
    public int ramp = 10;
    public int startDelay = 310;
    public GameObject zombiePrefab;

    private int delay;


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
    void FixedUpdate()
    {
        while (i < 1) // This condition should never happen, so the spawner is infinite, thus we use a fake counter
        {
            delay -= ramp;
            WaitFrames(delay);

            int j = Random.Range(0, 2);
            Instantiate(zombiePrefab, Spawns[j].position, Spawns[j].rotation);
        }
    }

    public IEnumerator WaitFrames(int amount) // taken from the "waitfor.cs" script, allows us to wait for a given amount of frames.
    {
        yield return StartCoroutine(WaitFor.Frames(amount));
    }
}
