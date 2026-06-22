using UnityEngine;
using System.Collections;

public class CarManager : MonoBehaviour
{
    public static CarManager Instance;

    [Header("Player")]
    public Camera playerCamera;
    public MonoBehaviour playerMove;
    public MonoBehaviour playerLook;

    [Header("UI")]
    public GameObject exitButton;

     

    private CarInteraction currentCar;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        exitButton.SetActive(false);
        
    }

    public void ShowEnterButton(CarInteraction car)
    {
        currentCar = car;
      


    }

    public void HideEnterButton()
    {
        
    }

    public void EnterCar()
    {
        Debug.Log("EnterCar called");
        if (currentCar == null)
            return;

        StartCoroutine(EnterCarRoutine());
    }

    private IEnumerator EnterCarRoutine()
    {
        yield return StartCoroutine(FadeController.Instance.FadeOut());

        playerCamera.gameObject.SetActive(false);
        currentCar.carCamera.gameObject.SetActive(true);

        playerMove.enabled = false;

        
        exitButton.SetActive(true);
       

        yield return StartCoroutine(FadeController.Instance.FadeIn());
    }

    public void ExitCar()
    {
        if (currentCar == null)
            return;

        StartCoroutine(ExitCarRoutine());
    }

    private IEnumerator ExitCarRoutine()
    {
         playerMove.enabled = true;
        yield return StartCoroutine(FadeController.Instance.FadeOut());
        playerCamera.gameObject.SetActive(true);
        currentCar.carCamera.gameObject.SetActive(false);
        

       

        exitButton.SetActive(false);
       

        yield return StartCoroutine(FadeController.Instance.FadeIn());
    }

    public void EnterCar(CarInteraction car)
{
    currentCar = car;

    playerCamera.gameObject.SetActive(false);
    car.carCamera.gameObject.SetActive(true);

    playerMove.enabled = false;

    exitButton.SetActive(true);
 
}
}