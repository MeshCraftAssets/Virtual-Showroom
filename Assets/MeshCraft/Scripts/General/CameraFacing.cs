using UnityEngine;

public class CameraFacing : MonoBehaviour
{
     private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void LateUpdate()
    {
        transform.LookAt(cam.transform);

        // Plane/Quad usually faces the opposite direction
        transform.Rotate(90f, 180f, 0f);
    }
}
