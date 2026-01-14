using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Ball;

public class RB1 : MonoBehaviour
{
    public GameObject dogs,perioxi;
    public GameObject OnomaPaikti;
    int metritis = 0; //koudounes
    int metritis1 = 0; //provatakia
    int metritis2 = 0;//emum provata g porta
    public GameObject Wood, secondempodio, stavlos, empodio, empodio3, empodiadogs,keimeno2portas,koutia,krummenoprovato,pinakida, woodenBoardKoudounes, woodenBoardgkioumpi, woodenBoardgklitsaKaiLaimaria;
    public GameObject keimenoaristera;//KEIMENO
    public AudioClip skulia, katastrofikormou, koudouness, provata, box, door,nope;
    string raycastobjectname;
    float apostasi;
    // Start is called before the first frame update
    void Start()
    {
        OnomaPaikti.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Playername");
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.F))//gia na anoigei portes
        {
            if (metritis2 == 2 && raycastobjectname== "stavlos" )// &&Wall.activeInHierarchy==true) raycastobjectname
            {
                Destroy(stavlos);
                Destroy(keimeno2portas);
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(door);
                metritis2 = 0;  //o metritis ginete 0 opote den leitourgei t F h na kanw Wall.SetActive(false);
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Τώρα πάρε το γκιουμί και \n σερβιρίσου λίγο γάλα στο ποτήρι.";
                woodenBoardgkioumpi.SetActive(true);
            }
            else if (metritis2 == 0 && raycastobjectname == "stavlos")
            {
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Είναι κλειδωμένο.";
            }
        }

         if (Input.GetKeyDown(KeyCode.T)) //gia na milaei
        {
            if ( raycastobjectname == "agrotis") 
            {
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Έχω χάσει 3 κουδούνες. \n Μπορείς να με βοηθήσεις να τις βρούμε;";
                Destroy(perioxi);
                woodenBoardKoudounes.SetActive(true);
            }
            if(raycastobjectname == "agrotis2")
            {
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Έχω χάσει δύο σημαντικά αντικείμενα. Τα λαιμαριά και την γκλίτσα.\n Βοήθαμε να τα βρουμε.";

                
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name=="koutia")
        {
            Destroy(collision.gameObject);
            metritis1 = metritis1 + 1;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(box);
        }

       if (collision.gameObject.name == "empodia_exit")
        {
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Δεν μπορώ να πάω πίσω.\n Θα χαθώ.";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if (collision.gameObject.name == "empodia_exit2")
        {
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Δεν είναι ο δρόμος για τη Χώρα.\n Πρέπει να πάω πίσω.";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if (collision.gameObject.name == "secondempodio")
        {
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Πως προέκυψε αυτός ο κορμός εδώ;\n Πως θα περάσω..";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if (collision.gameObject.name == "empodio")
        {
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Κάτι μου λέει ότι δεν είναι απο εδώ \n ο προορισμός μου.";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        
      
      
       


    }

    private void OnTriggerEnter(Collider other) //emfanizei ta skulia kai meta prepei n pethanoun
    {
        if(other.gameObject.name=="perioxi") //emfanizode t sklia
        {
          dogs.SetActive(true);
          this.gameObject.GetComponent<AudioSource>().PlayOneShot(skulia);
          keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Πρέπει να πετάξω κάτι κοντά του για να τo τρομάξω..";
            if (dogs.activeInHierarchy == true)
            {
                pinakida.SetActive(true);
            }
        }
        if(other.gameObject.name=="kakoksilo")
        {
            pinakida.SetActive(false);
        }
       

        if (other.gameObject.name=="koudouna") //3koudounesdestroy
        {
            Destroy(other.gameObject);
            metritis= metritis+1;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(koudouness);
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritis + " απο τις 3. "; //metritis apo koudounes
            if (metritis == 3) //katastrefei meta tis 3 koudounes to empodio
            {
                Destroy(secondempodio);
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(katastrofikormou);
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Κάτι ακούστηκε απο πίσω.. "; //metritis apo koudounes
                woodenBoardKoudounes.SetActive(false);

            }

        }
        if (other.gameObject.name == "krummenoprovato")
        {
            Destroy(other.gameObject);
            metritis2 = metritis2 + 1;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(provata);
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritis2 + " απο τα 2.";
            if (metritis2 ==2)
            {
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Πήγαινε να ανοίξεις την πόρτα. "; //metritis apo koudounes
                woodenBoardgklitsaKaiLaimaria.SetActive(true);
            }


        }
        if(other.gameObject.name =="ksilo")
        {
            koutia.SetActive(true);
            krummenoprovato.SetActive(true);
        }
        if(other.gameObject.name=="telos")
        {
            Destroy(empodio);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(katastrofikormou);
            keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Ήρθε η ώρα να συνεχίσω την πορεία μου.. ";
            woodenBoardgkioumpi.SetActive(false);
        }
        if (other.gameObject.name == "textkaitsu")
        {
            {
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Πάτα Τ για να μιλήσεις. ";
            }
        }
        if (other.gameObject.name == "giatonstavlo")
        {
            {
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Πάτα F για να ανοίξεις. ";
            }
        }
        if (other.gameObject.name == "textkaitsu2")
        {
            {
                keimenoaristera.GetComponent<TextMeshProUGUI>().text = "Πάτα το Τ για να τον ρώτήσεις για τις κουδούνες. ";
            }
        }
        



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "grass")
        {
            Destroy(empodio3);
        }
        if(other.gameObject.name =="ekklisia")
        {
            SceneManager.LoadScene(3);
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
