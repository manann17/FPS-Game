using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    Throwable This;

    // Start is called before the first frame update
    void Start()
    {
        transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
        This = GetComponent<Throwable>();
        transform.GetComponent<Rotation>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.GetComponent<Throwable>().inAir) transform.GetComponent<Rotation>().enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.GetComponent<Rotation>().enabled = false;
    }

}
