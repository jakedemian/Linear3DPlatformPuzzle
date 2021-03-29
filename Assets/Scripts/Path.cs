using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
    public GameObject[] points;

    public PointSet GetActivePointSet(Vector3 position) {
        for (int i = 0; i < points.Length; i++) {
            
            // FIXME what do we do when we're at the end of the last point of the path?  example: think of the elevator / mind slave
            // puzzle of inside.  how can i have different paths like that?  one option is to have TRANSITION POITNS instead of last normal points,
            // and the planes can have a script that does the logic of swapping active path?  i.e. when you go > than a plane, the plane,
            // has code to switch the active path.  when you go < than the plane, it switches back, etc.

            if (position.x > points[i].transform.position.x && position.x < points[i+1].transform.position.x) {
                return new PointSet(points[i], points[i+1]);
                break;
            }
        }

        return null;
    }
}

public class PointSet {
    public GameObject nextPoint;
    public GameObject prevPoint;

    public PointSet(GameObject prev, GameObject next) {
        prevPoint = prev;
        nextPoint = next;
    }
}
