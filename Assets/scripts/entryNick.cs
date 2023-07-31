using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class entryNick : MonoBehaviour
{
    public GameObject Download;
     public static string NickText;
    public TMP_InputField _InputField;
    public GameObject _Input;
    

void Update()
{
    NickText = _InputField.textComponent.text;
}
  
public void ApplyName()
{
    Download.SetActive(true);
    SceneManager.LoadScene("First");
}
}