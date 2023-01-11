using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("UI Components")]
    [SerializeField] private TextMeshProUGUI UIText;

    // Member variables
    private string m_ShapeName;
    private int m_Speed;

    // ENCAPSULATION

    // Encapsulated fields
    public string ShapeName
    {
        get { return m_ShapeName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Debug.LogError("The shape name can't be null or empty.");
                m_ShapeName = "Shape Name";
            }
            else
            {
                m_ShapeName = value;
            }
        }
    }

    public int speed
    {
        get { return m_Speed; }
        set
        {
            if (value < 0)
            {
                Debug.LogWarning("The speed can't be less than 0");
                m_Speed = 0;
            }
            else
            {
                m_Speed = value;
            }
        }
    }

    protected virtual void OnMouseDown()
    {
        DisplayText("I'm a shape");
    }

    // ABSTRACTION

    protected void DisplayText(string text)
    {
        UIText.text = text;
    }
}
