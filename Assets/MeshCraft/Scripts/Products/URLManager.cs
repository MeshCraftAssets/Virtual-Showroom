using System.Runtime.InteropServices;
using UnityEngine;

public class URLManager : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void OpenURLSameWindow(string url);
#endif

    public void OpenWebsite()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        OpenURLSameWindow("https://www.amazon.in");
#else
        Application.OpenURL("https://www.amazon.in");
#endif
    }
}