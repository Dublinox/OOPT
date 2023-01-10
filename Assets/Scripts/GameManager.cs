using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance { get; private set; }
    [Header("Links")]
    [TextArea(1, 3)] public string gitHubURL = "https://github.com/ReynaldoReyes03";
    [TextArea(1, 3)] public string projectRepositoryURL = "https://github.com/ReynaldoReyes03/Programming-Theory-Repository";
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
