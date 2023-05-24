using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SearchBtn_menu : MonoBehaviour
{
    private Text myText;
    public string myName;

    public void SearchByInput()
    {
        myText = GetComponent<Text>();
        myName = myText.text.ToString();
        SceneManager.LoadScene(1);
    }
 
}
