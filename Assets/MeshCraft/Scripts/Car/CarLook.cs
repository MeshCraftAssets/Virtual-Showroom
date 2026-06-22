using UnityEngine;

public class CarLook : MonoBehaviour
{
    public float sensitivity = 2f;

    private float yaw;
    private float pitch;

    private void OnEnable()
    {
        Vector3 rot = transform.localEulerAngles;

        yaw = rot.y;
        pitch = rot.x;

        // Convert 350° to -10° etc.
        if (pitch > 180f)
            pitch -= 360f;

        if (yaw > 180f)
            yaw -= 360f;
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;

        // Limit look range
        yaw = Mathf.Clamp(yaw, -80f, 80f);
        pitch = Mathf.Clamp(pitch, -20f, 40f);

        transform.localRotation = Quaternion.Euler(pitch, yaw, 0f);
    }
}