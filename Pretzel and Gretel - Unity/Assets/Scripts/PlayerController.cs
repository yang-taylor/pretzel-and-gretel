using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float speed;

    public Vector2 movement;


    public bool facingLeft = false;
    
    // UnityEngine.AI.NavMeshAgent nav;

    void Awake() 
    {
        // nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
		// nav.updateRotation = false;
		// nav.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x == 0 && movement.y == 0) {
            animator.SetBool("moving", false);

            
        }
        else {
            animator.SetBool("moving", true);
            if(movement.x > 0 && facingLeft) {
                
                //animator.SetBool("movingLeft", false); 
                Flip();
                 
            } 
            else if(movement.x < 0 && !facingLeft) {
               // animator.SetBool("movingLeft", true);   
               Flip();
            }
        }

    }

    void FixedUpdate() 
    {
        // Movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void Flip() {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        facingLeft = !facingLeft;
    }
}
