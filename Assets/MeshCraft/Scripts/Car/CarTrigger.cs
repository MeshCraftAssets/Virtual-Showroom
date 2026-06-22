using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    public CarInteraction car;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CarManager.Instance.ShowEnterButton(car);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CarManager.Instance.HideEnterButton();
        }
    }
}