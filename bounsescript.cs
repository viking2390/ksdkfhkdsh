using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounsescript:MonoBehaviour 
{


	Rigidbody2D ball;

	void Start() 
	{
		ball = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update() {
		var x = Input.GetAxisRaw ("Horizontal")* Time.deltaTime * 150.0f;
		var z = Input.GetAxisRaw("Vertical")* Time.deltaTime * 3.0f;

		 transform.Rotate(x,0,0);
		 transform.Translate(z,0,0);
	}

	void OnTriggerEnter2D(Collider2D col){
	if (col.tag=="wall")
	{
		ball.velocity = new Vector2(0,0);
		ball.AddForce(new Vector2(0,8), ForceMode2D.Impulse);

	}
	else
	{
		ball.velocity = new Vector2(0,0);
		ball.AddForce(new Vector2(0,8), ForceMode2D.Impulse);
	}
	
	}
}
