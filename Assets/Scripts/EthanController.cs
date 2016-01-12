using UnityEngine;
using System.Collections;

public class EthanController : MonoBehaviour {

	public float speed;

	private Rigidbody rbe;

	void Start(){
		rbe = GetComponent<Rigidbody>();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rbe.AddForce (movement * speed);
	}

}
