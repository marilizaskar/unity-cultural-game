using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseball : MonoBehaviour
{
    public GameObject leavesPrefab, leaveSpawn;
    public AudioClip epesee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "baseball")
        {
            float offset = Random.RandomRange(0.1f, 0.2f);
            Instantiate(leavesPrefab, new Vector3(leaveSpawn.transform.position.x + offset,
             leaveSpawn.transform.position.y + offset, leaveSpawn.transform.position.z + offset),
             leaveSpawn.transform.rotation);
            Debug.Log("xtupisa");
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(epesee);
        }
    }
}
