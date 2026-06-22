using UnityEngine;
using TMPro;

public class ObjectDetector : MonoBehaviour
{
    public TMP_Text crosshair;

    void Update()
    {
        // Mouse click (Desktop/WebGL)
        if (Input.GetMouseButtonDown(0))
        {
            DetectObject();
        }

        // Touch (Mobile)
        if (Input.touchCount > 0 &&
            Input.GetTouch(0).phase == TouchPhase.Began)
        {
            DetectObject();
        }
    }

    private void DetectObject()
    {
        if (Camera.main == null)
        {
            Debug.LogError("Main Camera not found!");
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            string objectId = hit.collider.gameObject.name;
            objectId = objectId.Replace("(Clone)", "").Trim();

            Debug.Log("Clicked Object: " + objectId);

            Product product =
                ProductManager.Instance.GetProduct(objectId);

            if (product != null)
            {
                ProductUI.Instance.Show(product);
            }
        }
    }
}