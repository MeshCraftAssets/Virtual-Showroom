using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ProductManager : MonoBehaviour
{
    public static ProductManager Instance;

    private Dictionary<string, Product> productDictionary =
        new Dictionary<string, Product>();

    public bool IsLoaded { get; private set; }

    private void Awake()
    {
        Instance = this;
        StartCoroutine(LoadProducts());
    }

    private IEnumerator LoadProducts()
    {
        string path = Path.Combine(
            Application.streamingAssetsPath,
            "ProductData.json"
        );

        Debug.Log("Loading Product Data From: " + path);

        UnityWebRequest request = UnityWebRequest.Get(path);

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(
                "Failed to load ProductData.json : " +
                request.error
            );

            yield break;
        }

        string json = request.downloadHandler.text;

        if (string.IsNullOrEmpty(json))
        {
            Debug.LogError("ProductData.json is empty!");
            yield break;
        }

        ProductList list =
            JsonUtility.FromJson<ProductList>(json);

        if (list == null || list.products == null)
        {
            Debug.LogError(
                "Failed to parse ProductData.json"
            );

            yield break;
        }

        foreach (Product product in list.products)
        {
            if (!string.IsNullOrEmpty(product.id))
            {
                productDictionary[product.id] = product;
            }
        }

        IsLoaded = true;

        Debug.Log(
            "Products Loaded Successfully: " +
            productDictionary.Count
        );
    }

    public Product GetProduct(string id)
    {
        if (productDictionary.TryGetValue(id, out Product product))
        {
            return product;
        }

        Debug.LogWarning("Product not found: " + id);

        return null;
    }
}