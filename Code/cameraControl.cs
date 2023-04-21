﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    /**
     * This script is attached to the camera.
     * It is used to control the camera movement.
     */
    public float senstivity = 50f;

    public Transform player;

    float xRotation = 0f;



    // Start is called before the first frame update

    void Start()

    {
        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;

    }



    // Update is called once per frame

    void LateUpdate()

    {

        float x = Input.GetAxis("Mouse X") * senstivity * Time.deltaTime;

        float y = Input.GetAxis("Mouse Y") * senstivity * Time.deltaTime;



        xRotation -= y;

        xRotation = Mathf.Clamp(xRotation, -60f, 60f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        player.Rotate(Vector3.up * x);

    }

}
