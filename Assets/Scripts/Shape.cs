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
    private int m_ShapeLife;

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

    public int ShapeLife
    {
        get { return m_ShapeLife; }
        set
        {
            if (value < 0)
            {
                Debug.LogWarning("The shape life can't be less than 0");
                m_ShapeLife = 0;
            }
            else
            {
                m_ShapeLife = value;
            }
        }
    }

    protected virtual void OnMouseDown()
    {
        DisplayText("I am a shape");
    }

    // ABSTRACTION

    protected void DisplayText(string text)
    {
        UIText.text = text;
    }
}
