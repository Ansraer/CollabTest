using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public float movementSpeed = 0.15f;
    public float movementRunSpeed = 0.5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float inputX = Input.GetAxis("Horizontal") * movementSpeed;
        float inputY = Input.GetAxis("Vertical") * movementSpeed;

        Debug.Log(inputX);

        float moveX = 0f;
        float moveY = 0f;

        if (inputX != 0)
        {
            moveX = movementSpeed;
            if(inputX > 0.5f)
                moveX = movementRunSpeed;

            if (inputX < 0)
                moveX *= -1;
        }

        if (inputY != 0)
        {
            moveY = movementSpeed;
            if (inputY > 0.5f)
                moveY = movementRunSpeed;

            if (inputY < 0)
                moveY *= -1;
        }



        
        this.transform.Translate(new Vector3(moveX, moveY, 0));
	}
}
