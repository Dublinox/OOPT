using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE

public class Cube : Shape
{
    private void Start()
    {
        ShapeName = transform.name;
        ShapeLife = 2;
    }

    // POLYMORPHISM

    protected override void OnMouseDown()
    {
        DisplayText("I am a cube");
    }
}
