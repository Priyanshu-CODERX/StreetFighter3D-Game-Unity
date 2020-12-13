﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate(){
    	Vector3 desiredPos = player.position + offset;
    	Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
    	transform.position = smoothPos;
    }
}
