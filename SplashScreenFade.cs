using UnityEngine;
using UnityEngine.UI;

public class SplashScreenFade : MonoBehaviour
{
    public Image splashScreenImage;
    public float fadeDuration = 1f;

    private CanvasGroup canvasGroup;
    private bool isFading = false;

    void Start()
    {
        canvasGroup = splashScreenImage.GetComponent<CanvasGroup>();
        FadeOut();
    }

    void Update()
    {
        if (isFading)
        {
            float alpha = Mathf.Clamp01(canvasGroup.alpha - (Time.deltaTime / fadeDuration));
            canvasGroup.alpha = alpha;

            if (alpha <= 0f)
            {
                isFading = false;
                // Load the main scene or perform other actions here
                // Example: SceneManager.LoadScene("MainMenu");
            }
        }
    }

    void FadeOut()
    {
        isFading = true;
        canvasGroup.alpha = 1f;
    }
}