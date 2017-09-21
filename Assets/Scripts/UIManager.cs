using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	[SerializeField] Text counterUI;
	[SerializeField] Transform gatito;
	int counter = 0;
	Vector2 reset;


	void Start () {
		
	}

	public void UpdateCounter () {
		counter += 1;
		counterUI.text = "Galletas: " + counter;
		if (counter == 10) {
			print ("You Win");
			gatito.transform.position = reset;
			counterUI.text = "You win";

		}
	}
}
