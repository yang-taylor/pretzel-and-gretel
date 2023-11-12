using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GretelController : MonoBehaviour
{
    public GameObject pretzel;

    

    public GameObject crumbPrefab;

    public float followDistance;

    NavMeshAgent nav;

    public float speed;

    public bool facingLeft = false;

    public Animator animator;

    PlayerController pc;

    private float crumbTime = 7.0f;
    private float timer = 0.0f;

    public int crumbsLost = 0;

    public float crumbLaunchSpeed = .05f;

    //private Vector3 _lastPosition;

    // List<float> movementsX = new List<float>();
    // List<float> movementsY = new List<float>();

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        // pretzel = GetComponent<Rigidbody2D>();

        //nav = GetComponent<NavMeshAgent>();
        nav = GetComponent<NavMeshAgent>();
		nav.updateRotation = false;
		nav.updateUpAxis = false;
        nav.speed = speed;

        pc = pretzel.GetComponent<PlayerController>();
        

        //_lastPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(pretzel.transform.position);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(crumbsLost < 8) {
                    Vector3 scale = this.transform.localScale;
                    scale.x *= .9f;
                    scale.y *= .9f;
                    this.transform.localScale = scale;
                    crumbsLost++;
                    GameObject crumb = Instantiate(crumbPrefab, this.transform.position, Quaternion.identity);
                    crumb.GetComponent<Rigidbody2D>().AddForce(
                        new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * crumbLaunchSpeed);
                }
                else {
                    Wait(2);
                    SceneManager.LoadScene("You Lost");
                }
        }

        // var heading = this.transform.position + pretzel.transform.position;
        // heaing.Normalize();
        // var newVector = heading * followDistance;
        
        //     var heading = this.transform.position + pretzel.transform.position;
        // Vector3 p = PointAlongDirection(this.transform.position, 
        //     (this.transform.position - pretzel.transform.position).normalized, 
        //     followDistance);
        // Vector3 current = this.transform.position;

        // // if(p.x > current.x) this.transform.position.x += speed; 
        // // if(p.x < current.x) this.transform.position.x -= speed; 
        // // if(p.y > current.y) this.transform.position.y += speed; 
        // // if(p.y < current.y) this.transform.position.y -= speed; 
        // this.transform.position -= p.normalized * speed;

        if(pc.movement.x == 0 && pc.movement.y == 0) {
            animator.SetBool("moving", false);

            
        }
        else {
            animator.SetBool("moving", true);
            if(facingLeft && !pc.facingLeft) {
                
                //animator.SetBool("movingLeft", false); 
                Flip();
                 
            } 
            else if(!facingLeft && pc.facingLeft) {
               // animator.SetBool("movingLeft", true);   
               Flip();
            }
        }

        // if(pretzel.transform.position.y > this.transform.position.y & 
        //     pretzel.transform.position.x > this.transform.position.x) {
        //     nav.SetDestination(pretzel.transform.position + new Vector3(-.5f, -.5f, 0));
        // }
        // else if (pretzel.transform.position.y > this.transform.position.y & 
        //     pretzel.transform.position.x < this.transform.position.x) {
        //         nav.SetDestination(pretzel.transform.position + new Vector3(.5f, -.5f, 0));
        // }
        // else if (pretzel.transform.position.y < this.transform.position.y & 
        //     pretzel.transform.position.x > this.transform.position.x) {
        //         nav.SetDestination(pretzel.transform.position + new Vector3(-.5f, .5f, 0));
        // }
        // else if (pretzel.transform.position.y < this.transform.position.y & 
        //     pretzel.transform.position.x < this.transform.position.x) {
        //         nav.SetDestination(pretzel.transform.position + new Vector3(.5f, .5f, 0));
        // }
        // else 

                //  float distance = Vector3.Distance(transform.position, pretzel.transform.position);

                // //  var heading =  pretzel.transform.position + this.transform.position;
                // // heading.Normalize();
                // // var newVector = heading * followDistance;
                // //Vector3 dir = (pretzel.transform.position - this.transform.position).normalized;

                // // new distance = followDistance, (heading * x).magnitude = 2;
                // //nav.SetDestination(new Ray(pretzel.transform.position + 0, ));
                // nav.SetDestination(pretzel.transform.position);
                // if(distance < followDistance) {
                //     nav.speed = .01f;
                // }
                // else nav.speed = speed;

            //  if(distance >= followDistance) {
            // //     nav.isStopped = false;
            //     // nav.enabled = true;
            //     // nav.Move(pretzel.transform.position);
            //     nav.SetDestination(pretzel.transform.position);

            //  }   
            // else {
            //     var heading = this.transform.position + pretzel.transform.position;
            //     heading.Normalize();
            //     var newVector = heading * followDistance;

            //     // new distance = followDistance, (heading * x).magnitude = 2;
            //     //nav.SetDestination(new Ray(pretzel.transform.position + 0, ));
            //     nav.SetDestination(newVector);
            // }
            timer += Time.deltaTime;
            if (timer > crumbTime)
            {
                if(crumbsLost < 8) {
                    Vector3 scale = this.transform.localScale;
                    scale.x *= .9f;
                    scale.y *= .9f;
                    this.transform.localScale = scale;
                    timer = timer - crumbTime;
                    crumbsLost++;
                    GameObject crumb = Instantiate(crumbPrefab, this.transform.position, Quaternion.identity);
                    crumb.GetComponent<Rigidbody2D>().AddForce(
                        new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * crumbLaunchSpeed);
                }
                else {
                    Wait(2);
                    SceneManager.LoadScene("You Lost");

                }

                
        }

    }

    void FixedUpdate () {

    }

    private void Flip() {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        facingLeft = !facingLeft;
    }

    Vector3 PointAlongDirection(Vector3 origin, Vector3 direction,
        float distance) {
        return origin + direction.normalized * distance;
    }
    
    private IEnumerator Wait(int seconds) {
        yield return new WaitForSeconds(seconds);
    }

}
