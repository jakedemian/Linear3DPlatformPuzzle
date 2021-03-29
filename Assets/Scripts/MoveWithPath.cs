using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPath : MonoBehaviour {
    public Path path;
    public float moveSpeed;
    
    private PointSet activePointSet;

    // Update is called once per frame
    void Update() {
        if (Input.GetAxisRaw("Horizontal") != 0f) {
            UpdateTarget();
            //Debug.Log("test");
            if (activePointSet != null) {
                DoPathMove(Input.GetAxisRaw("Horizontal"));
            }
        }
    }

    private void UpdateTarget() {
        activePointSet = path.GetActivePointSet(transform.position);
    }

    private void DoPathMove(float horizontal) {
        Vector3 next = activePointSet.nextPoint.transform.position;
        Vector3 prev = activePointSet.prevPoint.transform.position;
        Vector3 direction = (next - prev).normalized * horizontal * moveSpeed * Time.deltaTime;
        Vector3 moveVector = new Vector3(direction.x, 0f, direction.z); // we don't care about the y value of the path points
        transform.Translate(moveVector);
    }
}
