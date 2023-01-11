using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
            Application.OpenURL(GameManager.Instance.projectRepositoryURL);
#else
            Application.Quit();
#endif
    }
}
