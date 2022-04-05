using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwokRod : MonoBehaviour
{
    public Rigidbody rod;

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
        if (Input.GetKey(KeyCode.RightShift))
        {

            if (pull < maxY)
            {
                pull += Time.deltaTime * power;
            }
        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            rod.AddForce(transform.right * pull * booster);
            pull = 0;
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
