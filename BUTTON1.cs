using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTON1 : MonoBehaviour
{
    public string sceneToLoad; // Public string variable to define the scene name

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Loads the specified scene
    }
}
