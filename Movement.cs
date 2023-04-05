using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] AudioClip mainengine;
    [SerializeField] float mainthrust = 1000f;
    Rigidbody rb;
    [SerializeField] float rotationthrust = 1f;
    AudioSource audioSource;

  

    // Start is called before the first frame update
    void Start()
    {
      rb =  GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        processthrust();
        processrotation();
    }

    void processthrust() 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(0, 1, 0 * mainthrust * Time.deltaTime);
            if (audioSource.isPlaying == false)
            {
                audioSource.PlayOneShot(mainengine);
            }

        }
        else
        {
            audioSource.Stop();
        }

    }


   

    void processrotation()
    {


        if (Input.GetKey(KeyCode.A))
        {
            Applyrotation(rotationthrust);

        }
        else if (Input.GetKey(KeyCode.D))
        {

            Applyrotation(-rotationthrust);

        }



    }

    void Applyrotation(float RotationThisFrame)
    {
        rb.freezeRotation = true; // freezing rotation so we can manually rotate
        transform.Rotate(Vector3.forward * RotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; // unfreezing rotation so physics system can take over 
    }
}
 