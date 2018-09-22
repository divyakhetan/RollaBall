using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public int count;
	public Text CountText;
	public Text WinText;

	void Start() {
		rb = GetComponent<Rigidbody> ();  //since we want to access the rigid body component of the player
		count = 0;
		CountText.text = "Count:" + count.ToString ();
		WinText.text = "";
 	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false); // deactivate that tag
			count = count + 1;
			CountText.text = "Count:" + count.ToString ();

			if ( count >= 12)
				WinText.text = "You Win! :)";
		}
	}
}
