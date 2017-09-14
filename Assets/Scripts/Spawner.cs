using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField] GameObject galleta;

	void Start () {
		for (int i = 0; i < 10; i++) {
			float rndX = Random.Range (-6f, 6f);
			float rndY = Random.Range (-4f, 4f);
			Instantiate (galleta, new Vector3(rndX,rndY,0), Quaternion.identity);	
		}
	}
	void Update () {
		
	}
}
