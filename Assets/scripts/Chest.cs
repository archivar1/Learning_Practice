using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
private Animator anime;
public static bool ChestIsOpen = false;

   public string GetDescription()
    {
        return "Нажмите [E] чтобы открыть сундук";
    }
    
    public void Interact()
    {
    
      anime = GetComponent<Animator>();
      anime.Play("Open");
      ChestIsOpen = true;
    }
}

