using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape //Inheritance
{
    public string shapeName = "Sphere";
    public string shapeColor = "Green";

    

    //polymorphism
    public override string DisplayText()//overide method for shapeColor and shapeName
    {
        return $"{shapeColor} {shapeName}";
    }
    
}
