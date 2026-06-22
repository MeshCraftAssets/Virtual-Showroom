using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeController : MonoBehaviour
{
    public static FadeController Instance;

    private Image fadeImage;

    [SerializeField] private float fadeSpeed = 1.5f;

    private void Awake()
    {
        Instance = this;
        fadeImage = GetComponent<Image>();
    }

    public IEnumerator FadeOut()
    {
        float alpha = fadeImage.color.a;

        while (alpha < 1f)
        {
            alpha += Time.deltaTime * fadeSpeed;

            Color c = fadeImage.color;
            c.a = Mathf.Clamp01(alpha);
            fadeImage.color = c;

            yield return null;
        }
    }

    public IEnumerator FadeIn()
    {
        float alpha = fadeImage.color.a;

        while (alpha > 0f)
        {
            alpha -= Time.deltaTime * fadeSpeed;

            Color c = fadeImage.color;
            c.a = Mathf.Clamp01(alpha);
            fadeImage.color = c;

            yield return null;
        }
    }
}