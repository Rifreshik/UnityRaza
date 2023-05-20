using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InputText2 : MonoBehaviour
{
    private Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
        myText.text = "Çהאנמגא " +InputText.myName;

    }


}  
