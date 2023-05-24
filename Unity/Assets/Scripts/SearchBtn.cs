using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SearchBtn : MonoBehaviour
{
    public InputField input;
    private static DB db;

    // Scene 2
    public void Data_btn()
    {
        db.SaveData(input.text);
        SceneManager.LoadScene(1);
    }
}
