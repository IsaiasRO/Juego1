using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private float speed = 7;
	[SerializeField] UIManager uiManager;


	void Update () {
		if (Input.GetKey (KeyCode.W)&& transform.position.y <4) {
			transform.Translate (Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S)&& transform.position.y >-3.5) {
			transform.Translate (Vector2.down * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.A)&& transform.position.x >-9.6) {
			transform.Translate (Vector2.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D)&& transform.position.x <9.5) {
			transform.Translate (Vector2.right * Time.deltaTime * speed);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		uiManager.UpdateCounter ();
		Destroy (other.gameObject);

	}
}
