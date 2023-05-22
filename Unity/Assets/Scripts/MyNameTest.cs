using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyNameTest : MonoBehaviour
{

private Text myText;
void Start()
{
myText = GetComponent<Text>();
myText.text = "Здарова" + MyName.myName + "!!!!";
}

}
