using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

	public TextMesh buildingName;
	void Start () {
		buildingName.text = transform.name;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
