using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDFK : MonoBehaviour {
	public Transform prefab;
	int x = 200;
	// Use this for initialization
	void Start () {
		while (x > 0) {
			Instantiate (prefab, new Vector3 (x, 10, 10), Quaternion.identity);
			x -= 100;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
