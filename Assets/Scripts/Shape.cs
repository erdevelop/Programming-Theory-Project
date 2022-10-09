using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape // main class for Inheritance
{
    private string shapeName;
    private string shapeColor;

    // public Shape()
    // {
    //     Debug.Log("This is constructor method");
    // }

    public string ShapeName // encapsulation
    {
        get
        {
            if(shapeName != null)
            {
                return shapeName;
            }
            else
            {
                return null;
            }
            
        }
        set
        {
            shapeName = value;
        }
    }
    public string ShapeColor
    {
        get
        {
            if(shapeColor != null)
            {
                return shapeColor;
            }
            else
            {
                return null;
            }
        }
        set
        {
            shapeColor = value;
        }
    }
    
    //polymorphism
    public virtual string DisplayText()//virtual method for shapeColor and shapeName
    {
        return $"{shapeColor} {shapeName}";
    }
}
