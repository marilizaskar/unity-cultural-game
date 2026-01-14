using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GiaToAlloAllogo : MonoBehaviour
{
    int metritisfilo = 8;
    public GameObject keimeno3d, woodenBoardstavlou2, RodaniKaiAnemi,giagiaMesa2,giagiaMesa3;
    public AudioClip equipp, achiev;
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
        if (collision.gameObject.name == "fito")
        {
            Destroy(collision.gameObject);
            metritisfilo = metritisfilo + 1;
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritisfilo + " ριζάρια απο τα 16. "; //metritis apo paparounes
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
            if (metritisfilo == 16)
            {
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(achiev);

                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Μόλις ξεκλείδωσες 2 αντικείμενα. Πήγαινε πίσω στο σπίτι.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.green; // Ορίζει το χρώμα του κειμένου σε πράσινο
                woodenBoardstavlou2.SetActive(true);
                RodaniKaiAnemi.SetActive(true);
                Destroy(giagiaMesa2);
                giagiaMesa3.SetActive(true);


            }
        }
    }
}
