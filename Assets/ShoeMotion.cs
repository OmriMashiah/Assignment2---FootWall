using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeMotion : MonoBehaviour
{

    //

    private bool spacebarPressed = false;

    void Start()
    {
        //spacebarPressed = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spacebarPressed == false)
        {
            print("space key was pressed");
            transform.Translate(Vector3.forward * Time.deltaTime * 20);
            spacebarPressed = true;
        }
    }
}
