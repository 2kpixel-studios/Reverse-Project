using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float yRotateSpeed;
	public float xRotateSpeed;
	public GameObject camera;
	public GameObject projectilePrefab;

	private float verticalInput;
	private float horizontalInput;
	private float yAxisRotateInput;
	private float xAxisRotateInput;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		verticalInput = Input.GetAxis("Vertical");
		horizontalInput = Input.GetAxis("Horizontal");
		yAxisRotateInput = Input.GetAxis("Mouse X");
		xAxisRotateInput = Input.GetAxis("Mouse Y");

		//move the player forward and backwards
		transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

		//move the player left and right
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

		//rotate the player and camera around the y axis
		transform.Rotate(Vector3.up * yAxisRotateInput * Time.deltaTime * yRotateSpeed);

		//rotate the camera around the x axis
		camera.transform.Rotate(Vector3.right * xAxisRotateInput * Time.deltaTime * xRotateSpeed);

		//fires a projectile for each time the left mouse button is pressed
		if (Input.GetMouseButtonDown(0)) {
			GameObject obj = GameObject.Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 0.5f), transform.rotation);
			Projectile p = obj.GetComponent<Projectile>();

			if (p != null) {
				p.player = this;
			}
		}
	}
}
