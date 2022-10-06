using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cube cube = new Cube();
        cube.shapeColor = "blue";
        cube.shapeName = "Cube";

        Debug.Log("Cube color: " + cube.shapeColor);
        Debug.Log("Cube name: " + cube.shapeName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
