using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Valve : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Cylinder_Of_Drill;
    float y;

    //private void Start()
    //{
    //    Cylinder_Of_Drill = GameObject.Find("Cylinder_Of_Drill").transform;
    //}

    void Move_Drill()
    {
        Cylinder_Of_Drill.localPosition = new Vector3(0, 9.78f + y, 0.92f);
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.rotation.ToAngleAxis(out float x, ));
        //Debug.Log(transform.rotation.x);
        //if (Input.GetKey(KeyCode.T))
        //{
        //    transform.Rotate(1, 0, 0);
            
        //}
        //else if (Input.GetKey(KeyCode.Y))
        //{
        //    transform.Rotate(-1, 0, 0);
        //}
        y = transform.rotation.x;
        y = y * 2;
        //Debug.Log(y);
        Move_Drill();
    }
}
