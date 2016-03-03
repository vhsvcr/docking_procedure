using UnityEngine;
using System.Collections;
using System;

public class NewJoystick : MonoBehaviour
{

    public int rotSpeed = 10;
    public float rotAdjust = .5f;

    void Update()
    {




        if (Input.GetKey("left"))
        {

            print("The Left Key is pressed! And the camera turns!");
            transform.Rotate(Vector3.down * Time.deltaTime * rotSpeed);
        }

        if (Input.GetKey("right"))
        {
            print("The Right Key is being pressed.");
            transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed, Space.Self);
        }

        if (Input.GetKey("up"))
        {
            print("The up Key is being pressed.");
            transform.Rotate(Vector3.left * Time.deltaTime * rotSpeed, Space.Self);
        }

        if (Input.GetKey("down"))
        {
            print("The down Key is being pressed.");
            transform.Rotate(Vector3.right * Time.deltaTime * rotSpeed, Space.Self);
        }


        if (Input.GetKey("w"))
        {
            print("The w Key is being pressed.");
            transform.position += Vector3.forward * Time.deltaTime * rotSpeed * rotAdjust;
        }

        if (Input.GetKey("s"))
        {
            print("The s Key is being pressed.");
            transform.position += Vector3.back * Time.deltaTime * rotSpeed * rotAdjust;
        }

        if (Input.GetKey("a"))
        {
            print("The a Key is being pressed.");
            transform.position += Vector3.left * Time.deltaTime * rotSpeed * rotAdjust;
        }


        if (Input.GetKey("d"))
        {
            print("The d Key is being pressed.");
            transform.position += Vector3.right * Time.deltaTime * rotSpeed * rotAdjust;
        }








    }
}

