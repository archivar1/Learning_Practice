using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{
  public GameObject menu;
  public GameObject NicknameInput;
  void Start()
  {
      Cursor.lockState = CursorLockMode.Confined;
  }
  //Загрузка игровой сцены из главного меню
  public void PlayGame()
  {
    menu.SetActive(false);
    NicknameInput.SetActive(true);
  }
  //Выход из игры
  public void ExitGame()
  {
    Debug.Log("Игра закрыта");
    Application.Quit();
  }
}
