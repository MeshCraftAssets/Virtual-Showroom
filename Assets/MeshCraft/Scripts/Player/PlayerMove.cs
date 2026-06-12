using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.4f;
    [SerializeField] private float acceleration = 3f;
    [SerializeField] private float deceleration = 5f;

    private CharacterController controller;
    private Vector3 velocity;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {


    Debug.Log(controller.isGrounded);
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 targetMove =
            (transform.forward * v + transform.right * h).normalized * moveSpeed;

        float accel = targetMove.magnitude > 0.01f
            ? acceleration
            : deceleration;

        velocity = Vector3.Lerp(
            velocity,
            targetMove,
            accel * Time.deltaTime);

        controller.SimpleMove(velocity);
    }
}