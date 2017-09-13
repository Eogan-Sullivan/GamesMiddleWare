using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePhysicsCode : MonoBehaviour {

    Vector3 acceleration,velocity;
    float cor = 0.5f; //Co- Eficent of Restitioun


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        acceleration = /*Physics.gravity;*/ 9.8f * Vector3.down; 
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if (transform.position.y < 0.5f)
        {
            transform.position -= velocity * Time.deltaTime;
            velocity = - cor * velocity;
        }
		
	}
}
