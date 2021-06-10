using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
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
            anim.SetBool("dead", true);
            Destroy(gameObject, 3.0f);
        }
    }
}
