using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
