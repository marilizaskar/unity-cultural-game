using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AkouwButton : MonoBehaviour
{
    public TextMeshProUGUI inputtext;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    public void buttongiaepomeniskini()
    {
        SceneManager.LoadScene(1);
    }


    public void kleisimopaixnidiou()
    {
        Application.Quit();
    }


    

    public void buttongiamenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("Playername", inputtext.text);
    }

    



}
