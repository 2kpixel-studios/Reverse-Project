using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float rotateSpeed;
	private float verticalInput;
	private float horizontalInput;
	private float rotateInput;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		verticalInput = Input.GetAxis("Vertical");
		horizontalInput = Input.GetAxis("Horizontal");
		rotateInput = Input.GetAxis("Mouse X");

		//move the player forward and backwards
		transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

		//move the player left and right
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

		//rotate the player around the y axis
		transform.Rotate(Vector3.up * rotateInput * Time.deltaTime * rotateSpeed);
    }
}
