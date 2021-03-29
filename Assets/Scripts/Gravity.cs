using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    private float gravSpeed = -9.8f;
    public bool gravityActive = true;
    public LayerMask gravityCollisionLayer;
    
    private void FixedUpdate() {
        if (gravityActive) {
            //Dbg.Log("test");
            transform.Translate(new Vector3(0, gravSpeed * Time.deltaTime, 0));
        }
    }

    private void Update() {
        RaycastHit hit;
        if (gravityActive && Physics.Raycast(transform.position, -transform.up, out hit, 0.6f, gravityCollisionLayer)) {
            SetGravity(false);
            
            var y = hit.point.y;
            var halfHeight = GetComponent<Collider>().bounds.extents.y;
            transform.position = new Vector3(
                transform.position.x,
                y + halfHeight,
                transform.position.z
            );
        }
    }

    public void SetGravity(bool active) {
        gravityActive = active;
    }
    
    
}
