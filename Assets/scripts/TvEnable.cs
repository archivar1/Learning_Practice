using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvEnable : MonoBehaviour, IInteractable
{
   public GameObject TvScreen;
public static bool TvIsEnable = false;

   public string GetDescription()
    {
        return "Нажмите [E] чтобы включить телевизор";
    }
    
    public void Interact()
    {
    
      TvScreen.SetActive(true);
      TvIsEnable = true;
    }
}

