using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField]
    Animator ani = new Animator();

    private void Start()
    {
        ani = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ani.SetBool("IsFiring", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            ani.SetBool("IsFiring", false);
        }
    }
}
