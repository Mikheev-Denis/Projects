using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultRodController : MonoBehaviour
{
    // Start is called before the first frame update


    public Rigidbody rod;
    //public SpringJoint springJoint;

    public float booster;
    public float power;
    public float pull;
    public float maxY = 20;
    public float back;

    void Start()
    {
        rod = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            if (pull < maxY)
            {
                pull += Time.deltaTime * power;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rod.AddForce(transform.right * pull * booster);
            pull = 0;
        }

      /*  if (Input.GetKey(KeyCode.LeftShift))
        {
            back += Time.deltaTime * power;


            springJoint.spring = back;
            if (back >= 15)
            {
                back = 0;
            }

        }*/
    }
}

