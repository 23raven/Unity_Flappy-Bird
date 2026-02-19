using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string webURL = "https://google.com"; // куда перейти в WebGL

    public void PressExit()
    {
#if UNITY_EDITOR
        Debug.Log("Exit (Editor)");
        UnityEditor.EditorApplication.isPlaying = false;

#elif UNITY_WEBGL
        Debug.Log("Exit (WebGL)");
        Application.OpenURL(webURL); // браузер не даст закрыть вкладку

#else
        Debug.Log("Exit (Build)");
        Application.Quit();
#endif
    }
}
