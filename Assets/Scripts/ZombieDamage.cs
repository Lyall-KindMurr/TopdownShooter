using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerHealthSystem player = collision.gameObject.GetComponent<PlayerHealthSystem>();
            player.TakeDamage();
            Debug.Log("Player collided with me");
        }
    }
}
