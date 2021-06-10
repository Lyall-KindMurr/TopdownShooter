using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTracker : MonoBehaviour
{
    int enemiesSlain = 0;

    void Start()
    {
        enemiesSlain = 0;
    }

    public void AddKill()
    {
        enemiesSlain++;
    }

    public int GetKill()
    {
        return enemiesSlain;
    }
}
