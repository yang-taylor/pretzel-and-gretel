using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyScript : MonoBehaviour
{
    private float dir = 1f;
    private float rotation = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float tiltAroundZ = Input.GetAxis("Horizontal") * rotation * 10;
        Quaternion target = Quaternion.Euler(0, 0, rotation);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5.0f);
        if(rotation < 10f && dir > 0f) {
            rotation += 1f;
        }
        else if (rotation >= 10f) {
            Wait(2);
            rotation -= 1f;
            dir *= -1f;
        }
        else if(rotation > -10f && dir < 0f) {
            rotation -= 1f;
        }
        else if (rotation <= -10f ) {
            Wait(2);
            rotation += 1f;
            dir *= -1f;
        }
        
    }

    private IEnumerator Wait(int seconds) {
        yield return new WaitForSeconds(seconds);
    }
}
