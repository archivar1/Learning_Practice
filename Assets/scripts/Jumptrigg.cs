using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumptrigg : MonoBehaviour
{
    public static bool NpcJump = false;
    private GameObject obj;
    public void OnTriggerStay (Collider obj)
    {
        if (obj.tag == "Player")
        {
            NpcJump = true;
        }
    }
  public void OnTriggerExit (Collider obj)
    {
        if (obj.tag == "Player")
        {
            NpcJump = false;
        }
    }
    
}
