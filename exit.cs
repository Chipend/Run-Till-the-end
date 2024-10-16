using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    public Button exitButton; // Drag your button in the Inspector

    void Start()
    {
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    void OnExitButtonClicked()
    {
#if UNITY_EDITOR
        // Stop Play mode in the Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Exit the application
        Application.Quit();
#endif
    }
}