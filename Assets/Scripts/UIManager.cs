using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	[SerializeField] Text counterUI;
	int counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void UpdateCounter () {
		counter += 1;
		counterUI.text = "Galletas: " + counter;
	}
}
