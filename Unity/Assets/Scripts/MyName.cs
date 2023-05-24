using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyName : MonoBehaviour
{
   public static string myName;
   private Text myText;
   void Start()
    {
        myText = GetComponent <Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        myName = myText.text.ToString () ;
    }
}
