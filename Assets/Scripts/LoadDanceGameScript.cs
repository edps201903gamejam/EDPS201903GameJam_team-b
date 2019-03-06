using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDanceGameScript : MonoBehaviour {

    public void OnClick(){

        SceneManager.LoadScene("DanceScene");
    }
}
