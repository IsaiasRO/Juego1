using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	[SerializeField] Text counterUI;
	int counter = 0;

	void Start () {
		
	}
	

	public void UpdateCounter () {
		counter += 1;
		counterUI.text = "Galletas: " + counter;
	}
}
