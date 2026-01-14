using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class kouti : MonoBehaviour
{
    public GameObject koutipanw, koutipanw2, Nimatakrummena;
    public GameObject keimeno3d;
    public AudioClip koutaki,equipp;
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
        if (other.gameObject.name=="kleidi")
        {
            Destroy(other.gameObject);
            koutipanw.SetActive(false);
            koutipanw2.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(koutaki);
            if (koutipanw.activeInHierarchy==false&&koutipanw2.activeInHierarchy==true)
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πρέπει να πάρω τα νήματα.";
                Nimatakrummena.SetActive(true);
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
                Invoke("xronokathisterisi", 5);
            }

        }
    }
    void epanalipsi()
    {
        Debug.Log("Repeat!");
    }

    void xronokathisterisi()
    {
        Debug.Log("xronokathisterisi");
    }
}
