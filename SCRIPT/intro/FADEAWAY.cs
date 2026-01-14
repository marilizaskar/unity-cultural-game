using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FADEAWAY : MonoBehaviour
{
    public float fadeTime;
    private TextMeshProUGUI fadeawayText;
    // Start is called before the first frame update
    void Start()
    {
        fadeawayText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeTime > 0)
        {
            fadeTime -= Time.deltaTime;
            fadeawayText.color = new Color(fadeawayText.color.r, fadeawayText.color.g, fadeawayText.color.b, fadeTime);
        }
    }
}
