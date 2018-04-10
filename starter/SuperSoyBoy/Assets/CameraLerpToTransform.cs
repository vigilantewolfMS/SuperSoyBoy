﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerpToTransform : MonoBehaviour {

	public Transform camTarget;
	public float trackingSpeed;
	public float minX, minY, maxX, maxY;

	private void FixedUpdate()
	{
		if (camTarget != null) {
			var newPos = Vector2.Lerp(transform.position, camTarget.position, Time.deltaTime * trackingSpeed);
			var camPos = new Vector3 (newPos.x, newPos.y, -10f);
			var v3 = camPos;
			var clampX = Mathf.Clamp (v3.x, minX, maxX);
			var clampY = Mathf.Clamp (v3.y, minY, maxY);
			transform.position = new Vector3 (clampX, clampY, -10f);
		}
	}
}
