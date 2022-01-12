using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject PopUpWin;

    public void OpenWin(){
        PopUpWin.SetActive(true);
    }

    public void CloseWin(){
        PopUpWin.SetActive(false);
    }
}
