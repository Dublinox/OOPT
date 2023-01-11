using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE

public class Sphere : Shape
{
    private void Start()
    {
        ShapeName = transform.name;
        speed = 5;
    }

    // POLYMORPHISM

    protected override void OnMouseDown()
    {
        DisplayText("I am a sphere");
    }
}
