﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Vector2 velocity;

	public float smoothTimeY;
	public float smoothTimeX;

	public GameObject player;

	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCametaPos;

	// Use this for initialization
	void Start () {


		player = GameObject.FindGameObjectWithTag("Player");
	}


	// Update is called once per frame
	void FixedUpdate () {
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
	//	float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.x, smoothTimeY);

		transform.position = new Vector3(posX,0,transform.position.z);

		if (bounds)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCametaPos.x),
				//Mathf.Clamp(transform.position.y, minCameraPos.y, maxCametaPos.y),
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCametaPos.z));
		}
	}
}
