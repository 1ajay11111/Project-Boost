using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processinput();
    }

    void processinput()
    {

    if( Input.GetKey(KeyCode.L))
        {
            NewMethod();
        }

    }

    private void NewMethod()
    {
        rd.AddRelativeForce(Vector3.up * Time.deltaTime * 1000f);
    }

    Rigidbody rd;
   
}
