using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//

public class GKMovement : MonoBehaviour
{

    public float delta = 3f;  // Amount to move left and right from the start point
    public float speed = 2.5f;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 GKposition = startPos;
        GKposition.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = GKposition;
    }
}
