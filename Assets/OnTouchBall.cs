using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchBall : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject GoalText;
    public GameObject NoGoalText;

    private bool goal = false;

    //
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Shoe")
        {
            print("The shoe touched the ball!");
            rb.velocity = new Vector3(0, 0, 23);
        }

        if (col.gameObject.name == "Buffon")
        {
            if ((rb.velocity.sqrMagnitude < 0.01 && goal == false) || rb.IsSleeping() && goal == false)
            {
                NoGoalText.gameObject.SetActive(true);
            }

        }
        else if (col.gameObject.name == "WallBehindGK")
        {
            GoalText.gameObject.SetActive(true);
            goal = true;
        }
    }
}
