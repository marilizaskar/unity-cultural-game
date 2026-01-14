using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child : MonoBehaviour
{
    public GameObject watermelon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            watermelon.transform.parent = null;
            watermelon.AddComponent<Rigidbody>();
            watermelon.GetComponent<Rigidbody>().AddForce(transform.forward*100);
        }

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "watermelon")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(0.1f, 2.5f, 1.1f);
            collision.gameObject.transform.localEulerAngles = new Vector3(-180, 1.7f, -90f);
        }
    }
}


