using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public static string myName;
    private Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
        if (myText == null)
        {
            Debug.LogError("InputText does not have a Text component attached.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (myText != null)
        {
            myName = myText.text.ToString();
        }
    }
}