using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionPortas : MonoBehaviour
{

    public TextMeshProUGUI keimeno3d;
    public float openAngle = 100f;
    public float openSpeed = 2f;
    public bool isOpen = false;
    public AudioSource audioSource;
    public AudioClip doorSound;
    private Quaternion closedrotarion;
    private Quaternion openrotation;
    private Coroutine currentCoroutine;
    string raycastobjectname;
    float apostasi;
    public GameObject keimeno3dporta;
    // Start is called before the first frame update
    void Start()
    {
        closedrotarion = transform.rotation;
        openrotation = Quaternion.Euler(transform.eulerAngles + new Vector3 (0, openAngle, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) //gia na anoigw porta
        {
            if (currentCoroutine != null) StopCoroutine(currentCoroutine);
            currentCoroutine = StartCoroutine(ToggleDoor());
            
        }

    }

    private IEnumerator ToggleDoor()
    {
        if (audioSource && doorSound)
        {
            audioSource.PlayOneShot(doorSound);
        }
        Quaternion targetRotation = isOpen ? closedrotarion : openrotation;
        isOpen = !isOpen;

        while (Quaternion.Angle(transform.rotation, targetRotation) < 0.071f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * openSpeed);
            yield return null;
        }
        transform.rotation = targetRotation;
    }

   
}
