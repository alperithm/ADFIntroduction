using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float balloonScale = 3.0f;
	float exTimer = 100;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0.0f, -4.8f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
    	exTimer--;

		if(Input.GetKeyDown(KeyCode.Return)){
			rigidbody.AddForce(transform.up * 200);
			balloonScale = 2.0f;
			exTimer = 100;
			PlayerScaleChange();
    	}

    	if(Input.GetKey("right")){
			rigidbody.AddForce(transform.right * 5);
    	}else if (Input.GetKey("left")){
			rigidbody.AddForce(transform.right * -5);
    	}

    	if(Input.GetKey("up")){
			rigidbody.AddForce(transform.forward * 5);
    	}else if (Input.GetKey("down")){
			rigidbody.AddForce(transform.forward * -5);
    	}

    	if(exTimer > 0 && balloonScale <= 3.0f){
    		balloonScale += 0.2f;
    		PlayerScaleChange();
    	}

	}

	void PlayerScaleChange () {
		transform.localScale = new Vector3(balloonScale, balloonScale, balloonScale);
	}

	void OnCollisionEnter(Collision col) {
		if (col.collider.tag == "Player") {
        	Destroy(gameObject);
    	}
	}
}
