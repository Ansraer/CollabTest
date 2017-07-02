using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float moveUp = .1f;

        if (this.transform.position.y > 10)
            moveUp = -.1f;
        

        this.transform.Translate(new Vector3(0, moveUp, 0));


    }
}
