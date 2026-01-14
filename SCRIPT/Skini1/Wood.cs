using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wood : MonoBehaviour
{
   
    public GameObject dogs,keimenoaristera,perioxi;
    public AudioClip fevgei,nope;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "perioxi2")
        {
            Destroy(dogs);
            Destroy(perioxi);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(fevgei);
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Το τρόμαξα..Ας συνεχίσω..";
             

        }
    }
   
}
