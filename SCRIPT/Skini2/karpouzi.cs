using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class karpouzi : MonoBehaviour
{
    public GameObject watermelon, giatotrakter, woodenBoardKarpouzia;
    public GameObject keimenoari;
    public AudioClip ok;
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
        if (collision.gameObject.name=="watermelon")
        {
           
            keimenoari.GetComponent<TextMeshProUGUI>().text = "Τέλεια.Νομίζω πως μπορείς να συνεχίσεις την \n πορεία σου";
            giatotrakter.SetActive(true);
            woodenBoardKarpouzia.SetActive(true);


        }
    }

   
}
