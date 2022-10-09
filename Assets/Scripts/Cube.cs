using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape //Inheritance
{
    public string shapeName = "Cube";
    public string shapeColor = "Red";

    

    //polymorphism
    public override string DisplayText()//overide method for shapeColor and shapeName
    {
        return $"{shapeColor} {shapeName}";
    }
}
