using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    /**
     * This script is attached to the player.
     * It is used to shoot the arrow.
     */
    public float Range;
    public GameObject Arrow;
    public GameObject Cam;

    void shoot(){
        // Shoot the arrow
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, Range));
        Instantiate(Arrow, hit.point, transform.rotation);

    }
}
