using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform playerBody;

    [Header("Look Settings")]
    [SerializeField] private float sensitivity = 2f;
    [SerializeField] private float rotationSmoothTime = 0.15f;

    private float targetYaw;
    private float targetPitch;

    private float currentYaw;
    private float currentPitch;

    private float yawVelocity;
    private float pitchVelocity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void Update()
    {

        
        // // Rotate only while dragging mouse
        if (!Input.GetMouseButton(0) &&
            !Input.GetMouseButton(1) &&
            !Input.GetMouseButton(2))
        {
            return;
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        targetYaw += mouseX * sensitivity;
        targetPitch -= mouseY * sensitivity;

        targetPitch = Mathf.Clamp(targetPitch, -85f, 85f);

        currentYaw = Mathf.SmoothDampAngle(
            currentYaw,
            targetYaw,
            ref yawVelocity,
            rotationSmoothTime);

        currentPitch = Mathf.SmoothDampAngle(
            currentPitch,
            targetPitch,
            ref pitchVelocity,
            rotationSmoothTime);

        playerBody.rotation =
            Quaternion.Euler(0f, currentYaw, 0f);

        transform.localRotation =
            Quaternion.Euler(currentPitch, 0f, 0f);
    }
}