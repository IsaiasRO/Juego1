using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	[SerializeField] float speed = 5;
	[SerializeField] UIManager uiManager;

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.down * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector2.right * Time.deltaTime * speed);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		uiManager.UpdateCounter ();
		Destroy (other.gameObject);

	}
}
