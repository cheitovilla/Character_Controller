using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dupli : MonoBehaviour {
	
	public GameObject player;
	public Transform position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y < -50) {
			player.transform.position = position.transform.position;
		}		
}
}
