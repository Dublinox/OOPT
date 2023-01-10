using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE

public class Sphere : Shape
{
    private void Start()
    {
        ShapeName = transform.name;
        ShapeLife = 5;
    }

    // POLYMORPHISM

    protected override void OnMouseDown()
    {
        DisplayText("I am a sphere");
    }
}
