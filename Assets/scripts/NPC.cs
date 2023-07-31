using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class NPC : MonoBehaviour, IInteractable
{
private Animator anime;
public  GameObject interactionUI;
 public TextMeshProUGUI interactionText;


//Получение информауции об интерактивном объекте
   public string GetDescription()
    {
        return "Нажмите [E] чтобы поговорить";
    }
    //Действия при использовании кнопки взаимодействия
    public void Interact()
    {
      
    anime = GetComponent<Animator>();
    
     Invoke("visibleUi",3);
      interactionUI.SetActive(true);
        interactionText.text = "Привет";
        anime.Play("Talk");
      
    
    }

    public void visibleUi()
    {
         interactionUI.SetActive(false);
      
    }
  void Update()
  {
       anime = GetComponent<Animator>();
      if (Jumptrigg.NpcJump && PlayerMove.onGround == false)
      {
        Invoke("visibleUi",3);
      interactionUI.SetActive(true);
        interactionText.text = "Прыжок";
        anime.Play("Jump");
      }
      else if (Chest.ChestIsOpen)
      {
        Invoke("visibleUi",3);
      interactionUI.SetActive(true);
        interactionText.text = "Сундук";
        anime.Play("handshake");
        Chest.ChestIsOpen = false;
      }
      else if (TvEnable.TvIsEnable)
    {
    Invoke("visibleUi",5);
      interactionUI.SetActive(true);
        interactionText.text = "Посмотрим телевизор";
        anime.Play("Seat");
        TvEnable.TvIsEnable = false;
    }
  }
}