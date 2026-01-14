using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using System;

public class RB3 : MonoBehaviour
{

    int metritispaparounas = 0;
    int metritisfillwn;
    int metritisfila = 0;
    int metritisprovata = 0;
    string raycastobjectname;
    float apostasi;
    public GameObject keimeno3d, Diasimo, xiladiasimo, giagiaMesa4,argaleios,OnomaPaikti, giagiaMesaTelos,ufantos, giagiaMesa3;
    public AudioClip equipp,nope;
    public GameObject Nimatakrummena, woodenBoardstavlos, woodenBoardstavlosmepodio1, woodenBoardstavlosMesa, woodenBoardstavlosmepodio, EmpodioGENIKO2, kazaniEmpodio, EmpodioGENIKO, woodenBoardKastro, woodenBoardpaparouna, woodenBoardplateia, empodioplateias, Empodiostavlou, woodenBoardxorafi, empodiospiti, woodenBoardplateia2;
    public GameObject giagiaMesa, kazaniTrigger;



    // Start is called before the first frame update
    void Start()
    {
        OnomaPaikti.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Playername");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T)) //gia na milaei
        {
            if (raycastobjectname == "giagia")
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Θα σου μάθω πως να χειρίζεσαι έναν αργαλείο.  Αρχικά πήγαινε στον στάβλο.. ";
                Destroy(empodiospiti);
                Destroy(EmpodioGENIKO2);
                
            }
            else
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Δεν μπορώ να πάω πάνω χωρίς τη συγκατάθεση της γιαγιάς.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            if (raycastobjectname == "human1")
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Το λαογραφικό, έχει κλείσει. Εκεί απέναντι είναι το σπίτι \n της γιαγιάς Βέτας, θα σε βοηθήσει..";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white;

            }
            if(raycastobjectname == "giagiaMesa")
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Αφού έμαθες για το λαναρί, ήρθε η ώρα να μάθεις για το επόμενο αντικείμενο.\nΒρες το καζάνι στον πάνω όροφο\n και πήγαινε πίσω στο σπίτι...";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white; // Ορίζει το χρώμα του κειμένου σε πράσινο
                Destroy(kazaniEmpodio);
            }
            if(raycastobjectname == "giagiaMesa2")
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πήγαινε στο κάστρο, στη πλατεία και στο χωράφι για\n να μαζέψεις τα απαραίτητα υλικά για τα χρώματα του υφαντού.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white; // Ορίζει το χρώμα του κειμένου σε πράσινο
                Destroy(EmpodioGENIKO);
                woodenBoardpaparouna.SetActive(true);
            }
            if (raycastobjectname == "giagiaMesa3")
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πρέπει να βρείς το κλειδί για το σεντούκι. Έίναι κρυμμένο στα 'συνιθησμένα' μέρη έξω απο τις πόρτες..\n Έπειτα πήγαινε στον ξυλόφουρνο να \nπάρεις τα ξύλα και έλα στον τοίχο με τις τρύπες.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white; // Ορίζει το χρώμα του κειμένου σε πράσινο
            }
            if(raycastobjectname == "giagiaMesa4")
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Μπράβο! Ανακάλυψες όλα τα αντικείμενα για την διαδικασία του υφαντού στον αργαλειό.\n Πήγαινε στο σπίτι για να πάρεις ένα δώρο.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.green; // Ορίζει το χρώμα του κειμένου σε πράσινο
                argaleios.SetActive(true);
                giagiaMesaTelos.SetActive(true);

            }
            if (raycastobjectname == "giagiaMesaTelos")
            {

                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Σε ευχαριστώ για όλα! Ελπίζω να απόκτησες πολλές γνώσεις!\n Για δώρο, ορίστε αυτός ο υφαντός.";
                keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white; // Ορίζει το χρώμα του κειμένου σε πράσινο
                ufantos.SetActive(true);

            }
        }



    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "paparouna") //DEUTERO TASK
        {
            Destroy(collision.gameObject);
            metritispaparounas = metritispaparounas + 1;
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritispaparounas + " απο τις 3. "; //metritis apo paparounes
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
           
            if (metritispaparounas == 3)
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πρέπει να πάω στη πλατεία.."; //metritis apo paparounes
                Destroy(woodenBoardpaparouna);
                woodenBoardKastro.SetActive(true);

            }



        }
        if (collision.gameObject.name == "karudia 1(Clone)") //TRITO TASK
        {
            Destroy(collision.gameObject);
            metritisfillwn = metritisfillwn + 1;
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritisfillwn + " φύλλο απο τα 3. "; //metritis apo paparounes
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
            if(metritisfillwn == 3)
            {
                keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πρέπει να πάω στο χωράφι."; //metritis apo paparounes
                Destroy(woodenBoardplateia);
                Destroy(empodioplateias);
                Destroy(Empodiostavlou);
                woodenBoardxorafi.SetActive(true);
                woodenBoardplateia2.SetActive(true);    
            }
        }
        if(collision.gameObject.name == "grafeioStavlosPorta")//PORTA STAVLOU TEXT
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πάτα το F για να ανοίξεις και να κλείσεις την πόρτα.";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white; // Ορίζει το χρώμα του κειμένου σε πράσινο
        }
        if(collision.gameObject.name== "EmpodioGENIKO2") //ΕMPODIA
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Δεν νομίζω ότι πρέπει να πάω απο εδώ..";
            
        }
        if (collision.gameObject.name == "Empodiostavlou") //EMPODIA
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Δεν νομίζω ότι πρέπει να πάω απο εδώ..";
            
        }
        if (collision.gameObject.name == "prosekklisia") //EMPODIA
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Δεν νομίζω ότι πρέπει να πάω απο εδώ..";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if(collision.gameObject.name== "kazaniEmpodio")//EMPODIA
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Δεν μπορώ να πάω πάνω χωρίς τη συγκατάθεση της γιαγιάς.";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white;
        }
        if (collision.gameObject.name == "empodiospiti")
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Δεν μπορώ να πάω απο εδώ.";
        }
        if (collision.gameObject.name == "Nimatakrummena")
        {
            Destroy(Nimatakrummena);
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Ας πάω στον ξυλόφουρνο.";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white;
            xiladiasimo.SetActive(true);    
        }
        if (collision.gameObject.name == "xiladiasimo")
        {
            Destroy(xiladiasimo);
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Μόλις ξεκλείδωσες ένα αντικείμενο. Πήγαινε στον τοίχο με τις τρύπες.";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.green; // Ορίζει το χρώμα του κειμένου σε πράσινο
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equipp);
            Diasimo.SetActive(true);
            giagiaMesa4.SetActive(true);
            giagiaMesa3.SetActive(false);

        }









    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "EmpodioGENIKO")
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πρέπει να πάω στο σπίτι της γιαγιάς. ";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white; // Ορίζει το χρώμα του κειμένου σε πράσινο
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if (other.gameObject.name == "fortalking")
        {
            keimeno3d.GetComponent<TextMeshProUGUI>().text = "Πάτα το Τ για να μιλήσεις. ";
            keimeno3d.GetComponent<TextMeshProUGUI>().color = Color.white;
            if(raycastobjectname=="giagiaMesa")
            {
                Destroy(kazaniTrigger);
            }
        }
        if(other.gameObject.name== "woodenBoardstavlosmepodio1")//gia na emfanistei to task ston STAVLO
        {
            woodenBoardstavlos.SetActive(true); 
        }
        else if(other.gameObject.name == "woodenBoardstavlosmepodio") //gia na eksafanistei to task ston STAVLO
        {
            woodenBoardstavlos.SetActive(false);
            woodenBoardstavlosMesa.SetActive(true);
            Destroy(woodenBoardstavlosmepodio1);
        }
        if(other.gameObject.name== "woodenBoardstavlosMesa")
        {
            woodenBoardstavlosMesa.SetActive(false);
            Destroy(woodenBoardstavlosmepodio);
        }
        if(other.gameObject.name=="proto")//Emfanizete h giagia to lanari kai leei gia to adraxti
        {
            giagiaMesa.SetActive(true);

        }
        if (other.gameObject.name == "empodioplateias")
        {
            {
                woodenBoardplateia.SetActive(true); 
            }
        }
        if(other.gameObject.name== "triggerDiasimo")
        {
            Diasimo.SetActive(true);
        }
        if (other.gameObject.name == "ufantos")
        {
            SceneManager.LoadScene(0);
        }
            

        
      



    }



    private void Invoke(Action xronokathisterisi, int v)
    {
        throw new NotImplementedException();
    }

    void epanalipsi()
    {
        Debug.Log("Repeat!");
    }

    void xronokathisterisi()
    {
        Debug.Log("xronokathisterisi");
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