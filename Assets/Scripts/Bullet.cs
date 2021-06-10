using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int lifetime = 5;

    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Zombie")
        {
            HealthSystem enemy = other.GetComponent<HealthSystem>();
            enemy.TakeDamage();
            Debug.Log("Ow, that hurt");
            Destroy(gameObject);
        }
        
    }
}
