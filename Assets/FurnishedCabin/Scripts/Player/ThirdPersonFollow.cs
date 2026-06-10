using UnityEngine;

public class ThirdPersonFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 2, -4);

    void LateUpdate()
    {
        transform.position = player.position + player.rotation * offset;
        transform.LookAt(player.position + Vector3.up * 1.5f);
    }
}