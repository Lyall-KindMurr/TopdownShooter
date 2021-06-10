using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class PlayerHealthSystem : MonoBehaviour
{
    Animator anim;
    PlayerMovement controller;
    PlayerAttack controller2;
    NavMeshAgent agent;

    [SerializeField]
    Slider healthBar;
    [SerializeField]
    GameObject endscreen;
    [SerializeField]
    int maxHealth = 3;
    [SerializeField]
    int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        anim = this.GetComponent<Animator>();
        controller = this.GetComponent<PlayerMovement>();
        controller2 = this.GetComponent<PlayerAttack>();
        agent = GetComponent<NavMeshAgent>();
    }

    public void TakeDamage()
    {
        health--;
        healthBar.value = health;
        if (health <= 0)
            Dead();
    }

    private void Dead()
    {
        agent.isStopped = true;
        anim.SetBool("dead", true);
        controller.enabled = false; //we play the death animation, and disable the player's control
        controller2.enabled = false;
        endscreen.SetActive(true); // we pull up the game over menu
    }
}
