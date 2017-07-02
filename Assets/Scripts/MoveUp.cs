using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {

    float moveUp = .1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (this.transform.position.y > 10)
        {
            moveUp = -.1f;
            RotateCube();
        } else if (this.transform.position.y < 0)
            moveUp = .1f;

        this.transform.Translate(new Vector3(0, moveUp, 0));


    }

    void RotateCube()
    {
        Vector3 currentRotation = this.transform.rotation.eulerAngles;
        this.transform.Rotate(new Vector3(0,10,0));
    }

}
