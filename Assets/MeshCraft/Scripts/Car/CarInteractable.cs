using UnityEngine;

public class CarInteraction : MonoBehaviour
{
    public Camera carCamera;
    public GameObject enterIcon;

     private CarInteraction car;

    private void Start()
    {
        carCamera.gameObject.SetActive(false);
        enterIcon.SetActive(false);
        car = GetComponent<CarInteraction>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enterIcon.SetActive(true);
            CarManager.Instance.ShowEnterButton(car);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enterIcon.SetActive(false);
        }
    }

    public void EnterCar()
    {
        CarManager.Instance.EnterCar(this);
    }
}