using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code1 : MonoBehaviour
{
    public string name;
    public GameObject inputField;
    public GameObject textDisplay;
    
    public void storeName()
    {

        name = inputField.GetComponent<Text>().text;
        if(name == "Mango")
        {
            textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
            
        }
        else if (name == "Computer")
        {
            textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
        }
        else if (name == "Google")
        {
            textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
        }
        else if (name == "Uncharted4")
        {
            textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
        }
        else if (name == "Unreal")
        {
            textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
        }
        else if (name != "Mango"+ "Computer"+"Google"+"Uncharted04"+"Unreal")
        {
            textDisplay.GetComponent<Text>().text = "[" + name + "]is not Found";
        }

    }
    
}
