using UnityEngine;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using Unity.VisualScripting;
using System;
using System.Collections;
public class SecretCode : MonoBehaviour
{
        
    public InputField text_input;
    public GameObject Panel;

    public void ClickButtn_1(bool open)
    {
        string text = text_input.text; 
        if (text == "42") {
            Panel.SetActive(open);
        };
    }

}
