// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    /**
     * This script is attached to the player.
     * It is used to control the player movement.
     */


    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        // Get the animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Set the animator parameters
        animator.SetFloat("Strafe", horizontal);
        animator.SetFloat("Forward", vertical);

        // If the player is running, set the run parameter to true
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        
        if(Input.GetButton("Fire1"))
        {
            animator.SetBool("aim", true);
        }
        if(Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("aim", false);
            animator.SetBool("shoot", true);
        }
        else
        {
            animator.SetBool("shoot", false);
        }
     


       
    }
}
