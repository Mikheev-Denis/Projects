using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoBBack : MonoBehaviour
{
    public GameObject fxJoint;
    public Rigidbody tomato;
    public FixedJoint joint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            fxJoint.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            fxJoint.SetActive(true);
            joint.connectedBody = tomato;
            
        }
    }
}
