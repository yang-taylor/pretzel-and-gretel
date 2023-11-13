using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public Animator animator;

    public float speed;

    public Vector2 movement;

    public GameObject gretel;


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

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        Debug.Log(collision);

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "candy")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            
            gretel.GetComponent<GretelController>().crumbsLost -= 1;
            Vector3 scale = gretel.transform.localScale;
                    scale.x = scale.x * 10f / 9f;
                    scale.y = scale.y * 10f / 9f;
                    gretel.transform.localScale = scale;

            Destroy(collision.gameObject);
        }
    }
    
    /**void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("something");
            // Get the game manager
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.toCutscene1();
    }*/
}
