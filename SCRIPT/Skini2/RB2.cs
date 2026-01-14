using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Ball;

public class RB2 : MonoBehaviour
{
    public GameObject prosforoprefab, prosforoSpawnLocation;
    public GameObject OnomaPaikti;
    public GameObject empodiasepagkous1, empodiasepagkous, skales, gatakia, watermelon,trakter,trakterkrufo, woodenBoard, task1PinakasEnd,kotrona;
    public GameObject woodenProsfora, woodenBoardd, PetreleoOlo, woodenBoardd2,agrotis,agrotis2, woodenBoardKarpouzia;
    public GameObject keimenoari; //keimeno
    int metritisprosforo,metritisgatas;
    public AudioClip epese,nope,meow,kitty,equip,emfanisi,car;
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
        if (Input.GetKeyDown(KeyCode.T)) //gia na milaei
        {
            if (skales.activeInHierarchy == true && raycastobjectname == "agrotis")
            {
                keimenoari.GetComponent<TextMeshProUGUI>().text = "Πρέπει να βοηθήσεις και τους άλλους\n δύο συντοπίτες μου για να φύγει το τρακτέρ\nΠήγαινε πάνω στην εκκλησία."; ;
                gatakia.SetActive(true);
            }
            if (empodiasepagkous1.activeInHierarchy == false && raycastobjectname == "psaras")
            {
                keimenoari.GetComponent<TextMeshProUGUI>().text = "Θέλω αύριο να πάω για ψάρεμα..\nαλλά εχω χάσει την πετρελαιο λυχνεία μου.."; ;
                woodenBoardd.SetActive(true);
            }
            if (empodiasepagkous.activeInHierarchy == false && raycastobjectname == "karpouzas")
            {
                keimenoari.GetComponent<TextMeshProUGUI>().text = "Ζύγισε ένα καρπούζι στο καντάρι.\n Πάτα Ε για να το πετάξεις.";
                
            }
        }

      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "empodioforest")
        {
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Δεν υπάρχει λόγος να επιστρέψω \n στο δάσος.";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);


        }
        if (collision.gameObject.name== "sxoini")
        {
            float offset = Random.RandomRange(0.1f, 0.2f);
            Instantiate(prosforoprefab, new Vector3(prosforoSpawnLocation.transform.position.x + offset,
                prosforoSpawnLocation.transform.position.y + offset, prosforoSpawnLocation.transform.position.z + offset),
                prosforoSpawnLocation.transform.rotation);
            Debug.Log("xtupisa");
            

        }
        
        if (collision.gameObject.name== "empodiasepagkous")
        {
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Δεν έχω λίρες.\n Πρέπει να ρωτήσω κάποιον άλλον.";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if (collision.gameObject.name == "empodiasepagkous1")
        {
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Δεν έχω λίρες.\n Πρέπει να ρωτήσω κάποιον άλλον.";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(nope);
        }
        if (collision.gameObject.name == "prosforo(Clone)")
        {
            Destroy(collision.gameObject);
            metritisprosforo = metritisprosforo + 1;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equip);
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritisprosforo + " απο τα 2. ";
            if (metritisprosforo == 2) //gia t prosfora
            {


                keimenoari.GetComponent<TextMeshProUGUI>().text = "Τι μιαούρισμα ήταν αυτό; \n Πρέπει να πάω να δώ.";
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(meow);
                empodiasepagkous1.SetActive(false);
                woodenProsfora.SetActive(true);    

            }
            
            
        }
        if ( collision.gameObject.name =="cat")
        {
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(meow);
        }

        if (collision.gameObject.name == "petreleo")
        {
            Destroy(collision.gameObject);
            metritisgatas = metritisgatas + 1;
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Έχεις μαζέψει " + metritisgatas + " απο τα 3. ";
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(equip);
            if (metritisgatas == 3)
            {
                empodiasepagkous.SetActive(false);
                keimenoari.GetComponent<TextMeshProUGUI>().text = "Τα βρήκα..Θα δοκιμάσω να πάω απο τον πάγκο με τα καρπούζια..";
                PetreleoOlo.SetActive(true);
                woodenBoardd2.SetActive(false);
                woodenBoardd.SetActive(false);
            }
        }
        if (collision.gameObject.name == "watermelon")
        {
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            collision.gameObject.transform.parent = this.gameObject.transform;//EDOLIGIAPARENT
            collision.gameObject.transform.localPosition = new Vector3(0.1f, 2.5f, 1.1f);
            collision.gameObject.transform.localEulerAngles = new Vector3(-180, 1.7f, -90f);
        }
        if (collision.gameObject.name == "agrotis")
        {

            skales.SetActive(true);


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "stoxwrio")
        {
            SceneManager.LoadScene(4);
        }
        if(other.gameObject.name=="giatotrakter") //(skales.activeInHierarchy == true && raycastobjectname == "agrotis")
        {
            Destroy(trakter);
            trakterkrufo.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(car);
            woodenBoardKarpouzia.SetActive(false);
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Επιτέλους μπορώ να συνεχίσω!! ";
        }
        if(other.gameObject.name== "task1Pinakas")
        {
            woodenBoard.SetActive(true);
            kotrona.SetActive(false);
        }
        else if(other.gameObject.name== "task1PinakasEnd")
        {
            woodenBoard.SetActive(false);
        }
        if(other.gameObject.name=="pilino")
        {
            woodenBoardd2.SetActive(true);  
        }
       

    }

    private void OnTriggerStay(Collider other)
    {
      
        if (other.gameObject.name == "agrotisTask")
        {
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Πάτα το T για να μιλήσεις.";
            
           
        }
        
        if(other.gameObject.name=="kotrona2")
        {
            kotrona.SetActive(true);
        }
        if(other.gameObject.name=="kotrona")
        {
            agrotis2.SetActive(true);
            agrotis.SetActive(false);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(emfanisi);
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Ευτυχώς είναι λίγα τα σκαλοπάτια...";

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
