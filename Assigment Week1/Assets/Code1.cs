using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code1 : MonoBehaviour
{
    public string name;
    public GameObject inputField;
    public GameObject textDisplay;
    

    //public void storeName()
    //{

    //    name = inputField.GetComponent<Text>().text;
    //    if (name == "Mango")
    //    {
    //        textDisplay.GetComponent<Text>().text = "[  " + name + " ]is Found";

    //    }
    //    else if (name == "Computer")
    //    {
    //        textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
    //    }
    //    else if (name == "Google")
    //    {
    //        textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
    //    }
    //    else if (name == "Uncharted4")
    //    {
    //        textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
    //    }
    //    else if (name == "Unreal")
    //    {
    //        textDisplay.GetComponent<Text>().text = "[" + name + "]is Found";
    //    }
    //    else if (name != "Mango" + "Computer" + "Google" + "Uncharted4" + "Unreal")
    //    {
    //        textDisplay.GetComponent<Text>().text = "[" + name + "]is not Found";
    //    }

    //}
    public void buyName()
    {
        name = inputField.GetComponent<Text>().text;
        
        switch (name)
        {
            case "Mango":
                if (name == "Mango")
                textDisplay.GetComponent<Text>().text = "[ <color=green>" + name + "</color> ] is found";
                break;
            case "Computer":
                if (name == "Computer")
                    textDisplay.GetComponent<Text>().text = "[ <color=green>" + name +"</color>] is Found";
                break;
            case "Google":
                if (name == "Google")
                textDisplay.GetComponent<Text>().text = "[ <color=yellow>" + name + "</color>] is Found";
                break;
            case "Uncharted4":
                if (name == "Uncharted4")
                textDisplay.GetComponent<Text>().text = "[ <color=red>" + name + "</color>] is Found";
                break;
            case "Unreal":
                if (name == "Unreal") 
                textDisplay.GetComponent<Text>().text = "[ <color=green>" + name + "</color>] is Found";
                break;
            default:
                textDisplay.GetComponent<Text>().text = "[ <color=orange>" + name + "</color>] is not Found";
                break;
        }
    }

}
