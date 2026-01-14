using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paidi : MonoBehaviour
{
    public GameObject baseball,psalidi,kleidi,kazani;
    string raycastname;
    float apostasii;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            baseball.transform.parent = null;
            baseball.AddComponent<Rigidbody>();
            psalidi.transform.parent = null;
            psalidi.AddComponent<Rigidbody>();
            kleidi.transform.parent = null;
            kleidi.AddComponent<Rigidbody>();
            kazani.transform.parent = null;
            kazani.AddComponent<Rigidbody>();


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "baseball")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(1.605124f, -0.06546725f, 0.2875353f);
            collision.gameObject.transform.localEulerAngles = new Vector3(7.523f, -55.996f, 2.415f);
        }
        if (collision.gameObject.name == "psalidi")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(1.11f, 0.144f, -0.279f);
            collision.gameObject.transform.localEulerAngles = new Vector3(-1.79f, -56.387f, 2.395f);
        }
        if (collision.gameObject.name == "kleidi")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(0.595f, 0.514f, -0.088f);
            collision.gameObject.transform.localEulerAngles = new Vector3(86.175f, 84.978f, 141.228f);
        }
        if (collision.gameObject.name == "kazani")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(0.78f, 0.124f, -0.169f);
            collision.gameObject.transform.localEulerAngles = new Vector3(-1.811f, -56.388f, 2.395f);
        }

    }

    private void FixedUpdate() //RAYCAST
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, 100))
        {
            raycastname = hit.collider.gameObject.name;
            apostasii = hit.distance;
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        else
        {
            raycastname = null;
            apostasii = 0;
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward) * 100, Color.red);
            Debug.Log("Den vlepw tipota");
        }
    }
}