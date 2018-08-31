﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public void cambiarEscena(string escena){
		SceneManager.LoadScene(escena);
	}

	public void salir(){
		Application.Quit();
	}

    public void saveScore(UnityEngine.UI.InputField name) {
        if (name.text != "") {
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);

            //Guardar en archivo

            InfoPlayer.setScore(0f);
            Player.score = 0f;
        } else {
            //name.selectionFocusPosition = 0;
            name.Select();
            name.GetComponent<UnityEngine.UI.Image>().color = Color.red;
        }

    }


}
