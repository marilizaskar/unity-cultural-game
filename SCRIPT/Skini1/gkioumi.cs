using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gkioumi : MonoBehaviour
{
    public GameObject milk, telos;
    public AudioClip gala;
    public GameObject keimenoari;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "potiri")
        {
            milk.SetActive(true);
            telos.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(gala);
           


            keimenoari.GetComponent<TextMeshProUGUI>().text = "Ας πάω προς τα πίσω..";
        }
    }


}
