using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public PlayerController player;
	public float speed;
	public float projectileDistance = 10.0f;
	
	// Start is called before the first frame update
	void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
		if(gameObject.transform.position.z >= projectileDistance || gameObject.transform.position.z <= -projectileDistance) {
			Destroy(gameObject);
		}
		void OnCollisionEnter(Collider collider) {
			if(collider.name != "Player") {
				Destroy(gameObject);
				Debug.Log("The projectile collided with a collider!");
			}
		}
    }
}
