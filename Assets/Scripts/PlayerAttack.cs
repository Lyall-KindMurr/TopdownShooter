using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    Animator ani = new Animator();
    [SerializeField]
    Transform firePoint;
    public GameObject bulletPrefab;

    private void Start()
    {
        ani = this.GetComponent<Animator>();
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) Attack();
    }

    void Attack()
    {
        ani.SetTrigger("Fire");
    }
}
