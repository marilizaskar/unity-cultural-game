using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PsalidiGiaProvata : MonoBehaviour
{
    int metritisprovata;
    public GameObject keimeno3d,lanari,giagia;
    public AudioClip mpee,completee;
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
        if (other.gameObject.name=="provata")
        {
            Destroy(other.gameObject);
            metritisprovata = metritisprovata + 1;
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritisprovata + " πρόβατα απο τα 3. "; //metritis apo paparounes
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(mpee);
            if( metritisprovata == 3 )
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Μόλις ξεκλείδωσες ένα αντικείμενο. \nΠήγαινε στο σπίτι να δείς.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.green; // Ορίζει το χρώμα του κειμένου σε πράσινο
                lanari.SetActive(true);
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(completee);
                giagia.SetActive(false);
                
            }
        }
    }
}
