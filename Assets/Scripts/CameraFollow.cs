using UnityEngine;
using System.Collections;
     
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime;
    
    private Vector3 velocity = Vector3.zero;
     
    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));
     
        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.LookAt(target);
    }
}