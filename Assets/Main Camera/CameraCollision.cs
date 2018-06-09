using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{

    public bool lockCursor;
    public float mouseSensitivity = 10;
    public Transform target;
    public float dstFromTarget = 3;

    public float rotationSmoothTime = .12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    public float minPitch = -40;
    public float maxPitch = 85;

    float yaw;
    float pitch;

    Vector3 center = new Vector3(0f, 0.5f, 0f);
    RaycastHit hit;

    private void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
        transform.eulerAngles = currentRotation;

        Vector3 wantedCameraPosition = target.position + center - transform.forward * dstFromTarget;

        // Raycasting 
        Vector3 rayDirection = (wantedCameraPosition - (target.position + center)).normalized;

        if (Physics.Raycast(target.position + center, rayDirection, out hit, dstFromTarget)
            && hit.transform != target.parent) // ignore ray-casts that hit the user. DR
        {
            // Debug.Log(hit.transform.name  + " " + direction.ToString());
            wantedCameraPosition.x = hit.point.x;
            wantedCameraPosition.z = hit.point.z;
            //wantedPosition.y = wantedPosition.y);
        }

        transform.position = wantedCameraPosition;
    }
}
