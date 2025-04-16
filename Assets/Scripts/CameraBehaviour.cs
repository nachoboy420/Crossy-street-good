using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target; // The player or car
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
   
// Start is called once before the first execution of Update after the MonoBehaviour is created
    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }
        
    }
    
}
    
