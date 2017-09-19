using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	[SerializeField] Text counterUI;
	int counter = 0;
	[SerializeField] Transform gatito;
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
