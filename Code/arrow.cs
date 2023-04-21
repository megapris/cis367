// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    /**
     * This script is attached to the arrow prefab.
     * It is used to move the arrow towards the target.
     * The target is set by the player script.
     */
    public Vector3 target;
    public float speed;

    // Start is called before the first frame update
    void Update(){
        // Move the arrow towards the target
        float step = Time.deltaTime * speed;
        // If the target is not null, move the arrow towards it
        if(target != null){
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
    }

    // Set the target
    public void setTarget(Vector3 newTarget){
        target = newTarget;
    }
}
