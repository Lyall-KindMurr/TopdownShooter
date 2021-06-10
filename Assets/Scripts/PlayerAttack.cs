using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    Animator ani = new Animator();
    [SerializeField]
    Transform firePoint;
    public GameObject bulletPrefab;

    NavMeshAgent agent;

    private void Start()
    {
        ani = this.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    public void Shoot() //function only to be called from within the animator
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);      
    }

    public void StartShoot() //functions used from the animator, to allow better integration with navmesh
    {
        agent.isStopped = true;
    }

    public void StopShoot() 
    {
        agent.isStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Attack();
    }

    private void Attack()
    {
        ani.SetTrigger("Fire");
    }
}
