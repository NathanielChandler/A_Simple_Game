using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveMod;
    public float turnSpeed;


    private Vector3 movement;
   // private Rigidbody playerRigidbody;

    // Use this for initialization
    void Start () {
       // playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Turn();
	}

    void Move(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * moveMod * Time.deltaTime;
        //playerRigidbody.MovePosition(transform.position + movement);
        transform.Translate(movement);
    }

    void Turn()
    {
        float direction = 0;
        if(Input.mousePosition.x > 5 * Screen.width/9)
        {
            direction = Input.mousePosition.x / Screen.width;
        }
        else if (Input.mousePosition.x < 4 * Screen.width / 9)
        {
            direction = -1 * (1 - Input.mousePosition.x / Screen.width);
        }
        Vector3 manip = new Vector3(0, direction * turnSpeed, 0);
        transform.Rotate(manip);
       // playerRigidbody.MoveRotation(Quaternion.Euler(manip));
    }
}
