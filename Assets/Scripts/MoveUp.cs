using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {

    public Material blue;
    public Material red;

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
            moveUp = -.1f;
        else if (this.transform.position.y < 0)
        {
            moveUp = .1f;
            this.GetComponent<Renderer>().material = red;
        }
            
        this.transform.Translate(new Vector3(0, moveUp, 0));



    }
}
