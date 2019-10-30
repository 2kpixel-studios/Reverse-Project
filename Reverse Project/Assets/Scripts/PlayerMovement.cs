using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	private float verticalInput;
	private float horizontalInput;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		verticalInput = Input.GetAxis("Vertical");
		horizontalInput = Input.GetAxis("Horizontal");

		//move the player forward and backwards
		transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

		//move the player left and right
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
