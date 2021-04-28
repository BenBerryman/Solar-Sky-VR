using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMotion : MonoBehaviour
{
    public float speed;
    public enum rotation {World, Self};
    public rotation RotationType;
    [Header("Orbital Axes")]
    public bool X;
    public bool Y;
    public bool Z;
    private float rotateX, rotateY, rotateZ;
    public bool Counterclockwise;

    // Start is called before the first frame update
    void Start()
    {
        speed /= 500;
        if (Counterclockwise) {
            speed *= -1;
        }
        rotateX = (X) ? speed : 0;
        rotateY = (Y) ? speed : 0;
        rotateZ = (Z) ? speed : 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (RotationType == rotation.World) {
            
            transform.Rotate(rotateX, rotateY, rotateZ, Space.World);
        }
        else {
            transform.Rotate(rotateX, rotateY, rotateZ, Space.Self);
        }
    }
}
