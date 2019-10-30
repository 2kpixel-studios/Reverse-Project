using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

	public GameObject player;
	private Vector3 offset = new Vector3(0.6f, 1.35f, -4.3f);

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		transform.position = player.transform.localPosition + offset;
		transform.rotation = player.transform.localRotation;
		
    }
}
