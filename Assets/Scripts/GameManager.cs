using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    public static GameManager Instance { get; private set; }
    [Header("Links")]
    
    [TextArea(1, 3)] public string projectRepositoryURL = "https://github.com/Dublinox";
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
