using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makegkioumi : MonoBehaviour
{
    string raycastobjectname;
    float apostasi;
    public GameObject gkioumi4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            gkioumi4.transform.parent = null;
            gkioumi4.AddComponent<Rigidbody>();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "gkioumi4" && raycastobjectname == "gkioumi4")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(0.1f, 0.3f, 1.1f);
            collision.gameObject.transform.localEulerAngles = new Vector4(0f, 9f, -361.416f);
        }
    }

    private void FixedUpdate() //RAYCAST
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, 100))
        {
            raycastobjectname = hit.collider.gameObject.name;
            apostasi = hit.distance;
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        else
        {
            raycastobjectname = null;
            apostasi = 0;
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward) * 100, Color.red);
            Debug.Log("Den vlepw tipota");
        }
    }

}


