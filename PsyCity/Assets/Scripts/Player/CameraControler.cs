﻿using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour 
{
	public GameObject followTarget;
	private Vector3 targetPos;
	public float moveSpeed;

	private static bool cameraExists;

	// Use this for initialization
	void Start () {
		if (!cameraExists) 
		{
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else
			Destroy(gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		targetPos = new Vector3 (followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
		//lerp = (where you are, where you want to be,speed )
		transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
