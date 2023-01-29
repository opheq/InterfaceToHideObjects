using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TurnOnUI : MonoBehaviour
{
    public GameObject UI;

    public void OnButton_Click(){
        UI.SetActive(!UI.activeSelf);
    }
}
