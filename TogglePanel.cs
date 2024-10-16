using UnityEngine;
using UnityEngine.UI;

public class TogglePanel : MonoBehaviour
{
    public GameObject panel; // Seret panel ke sini di Inspector
    private bool isPanelActive = false;

    public void TogglePanelVisibility()
    {
        isPanelActive = !isPanelActive;
        panel.SetActive(isPanelActive);
    }
}