using UnityEngine;

public class HeadBob : MonoBehaviour
{
    public float bobSpeed = 8f;
    public float bobAmount = 0.03f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f ||
            Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
        {
            float y = startPos.y + Mathf.Sin(Time.time * bobSpeed) * bobAmount;
            transform.localPosition = new Vector3(startPos.x, y, startPos.z);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                startPos,
                10f * Time.deltaTime);
        }
    }
}