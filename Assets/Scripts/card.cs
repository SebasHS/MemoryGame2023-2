using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
   public GameObject CardOpen;

   public GameObject CardClose;

   private bool isClosed = true;

   public void CardOnClick(){
    if (isClosed==true){
        CardClose.SetActive(false);
        CardOpen.SetActive(true);
        isClosed=false;
    }else{
        CardClose.SetActive(true);
        CardOpen.SetActive(false);
        isClosed=true;
    }
   }
}
