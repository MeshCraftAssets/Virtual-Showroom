using TMPro;
using UnityEngine;

public class ProductUI : MonoBehaviour
{
    public static ProductUI Instance;

    public GameObject panel;

    public TMP_Text nameText;
    public TMP_Text typeText;
    public TMP_Text priceText;

    private void Awake()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void Show(Product product)
    {
        panel.SetActive(true);

        nameText.text = product.name;
        typeText.text = product.type;
        priceText.text = "$" + product.price;
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}