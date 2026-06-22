using UnityEngine;

public class CarCameraIconClickEvent : MonoBehaviour
{
   
    private void OnMouseDown()
    {
        Debug.Log($"{gameObject.name} was clicked!");

        CarManager.Instance.EnterCar();
    }
}