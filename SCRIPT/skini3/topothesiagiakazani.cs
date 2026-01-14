using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class topothesiagiakazani : MonoBehaviour
{
    public AudioClip equipp;
    public GameObject kazani2,keimeno3d,giagiaMesa,proto,giagiaMesa2,Adraxti;
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
        if (other.gameObject.name=="kazani")
        {
            other.gameObject.SetActive(false);
            kazani2.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Μόλις ξεκλείδωσες δύο αντικείμενα. \nΠήγαινε στο σπίτι να δείς.";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.green; // Ορίζει το χρώμα του κειμένου σε πράσινο
            Destroy(giagiaMesa);
            Destroy(proto);
            giagiaMesa2.SetActive(true);
            Adraxti.SetActive(true);
        }

    }
}
