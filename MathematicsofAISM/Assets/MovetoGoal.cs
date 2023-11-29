using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoGoal : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public float accuracy = 0.5f;
    public Transform goal;

    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.yellow);
        if(direction.magnitude > accuracy)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
