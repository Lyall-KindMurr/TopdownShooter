using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealthSystem : MonoBehaviour
{
    NavMeshAgent agent;
    CapsuleCollider col;

    public scoreTracker trak;

    [SerializeField]
    int maxHealth = 2;
    [SerializeField]
    int health = 2;
    Animator anim = new Animator();

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        health = maxHealth;
        agent = GetComponent<NavMeshAgent>();
        col = GetComponent<CapsuleCollider>();
    }

    public void TakeDamage()
    {
        health--;
        CheckDead();
    }

    private void CheckDead()
    {
        if(health <= 0)
        {
            Die();
            trak.AddKill();
            anim.SetBool("dead", true);
            Destroy(gameObject, 3.0f);
        }
    }

    public void Die()
    {
        agent.isStopped = true;
        col.enabled = false; //turn off colisions with dead bodies
    }
}
