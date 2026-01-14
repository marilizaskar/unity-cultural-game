using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AletriKaiAlogo : MonoBehaviour
{
    int metritisfilou;
    public GameObject keimeno3d;
    public GameObject alogokaialetri2,myObject, woodenBoardplateia2;
    public AudioClip equipp, achiev;
    // Start is called before the first frame update
    void Start()
    {
        myObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="fito")
        {
            Destroy(collision.gameObject);
            metritisfilou = metritisfilou + 1;
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritisfilou + " ριζάρια απο τα 16. "; //metritis apo paparounes
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
            if( metritisfilou==8)
            {
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(achiev);
                alogokaialetri2.SetActive(true);
                woodenBoardplateia2.SetActive(false);
                myObject.SetActive(false);
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
        Debug.Log("Xronokathisterisi");
    }

    void DisableObject()
    {
        myObject.SetActive(false);
    }
}
