﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamer : MonoBehaviour {

    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;
	
	// Update is called once per frame
	void Update () {

        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        Quaternion portalTotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalTotationalDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);

	}
}