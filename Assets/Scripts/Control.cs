using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    float speed = 5f;
    bool isSpinning = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpinning == true)
        {
           transform.Rotate(Vector3.down * speed);
        }
    }

    public void FanSpin() // spin the trent 1000
    {
        isSpinning = true;
    }

    public void StopSpin() //stop aka pause
    {
        isSpinning = false;
    }


}
