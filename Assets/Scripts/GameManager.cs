using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text cubeText, sphereText, capsuleText;
    [SerializeField] Cube cube;
    [SerializeField] Sphere sphere;
    [SerializeField] Capsule capsule;



    // Start is called before the first frame update
    void Start()
    {
        cube = new Cube(); //referance object for cube
        sphere = new Sphere(); // reference object for sphere
        capsule = new Capsule(); // reference object for capsule

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CubeButton() // CubeButton OnClick call method
    {
        cubeText.text = cube.DisplayText();
        // cubeText.text = cube.GetShapeColorAndName(cube.shapeColor, cube.shapeName); // cube default class variables value assigment to cube text
    }
    public void SphereButton() // SphereButton OnClick call method
    {
        sphereText.text = sphere.DisplayText();
        // sphereText.text = sphere.GetShapeColorAndName(sphere.shapeColor, sphere.shapeName); // sphere default class variables value assigment to sphere text
    }
    public void CapsuleButton() // CapsuleButton OnClick call method
    {
        capsuleText.text = capsule.DisplayText();
        // capsuleText.text = capsule.GetShapeColorAndName(capsule.shapeColor, capsule.shapeName); // capsule default class variables value assigment to capsule text
    }
}
