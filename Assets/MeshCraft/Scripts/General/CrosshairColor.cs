using UnityEngine;
using TMPro;

public class CrosshairColor : MonoBehaviour
{
    public TMP_Text crosshair;

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(
            new Vector3(0.5f, 0.5f, 0)
        );

        if (Physics.Raycast(ray, out RaycastHit hit, 100f))
        {
            crosshair.color = Color.green;
        }
        else
        {
            crosshair.color = Color.white;
        }
    }
}