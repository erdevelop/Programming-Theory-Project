using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape //Inheritance sub class
{
    public string shapeName = "Capsule";
    public string shapeColor = "Blue";

    

    //polymorphism
    public override string DisplayText()//overide method for shapeColor and shapeName
    {
        return $"{shapeColor} {shapeName}";
    }
}
