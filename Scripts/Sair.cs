using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sair : MonoBehaviour {


	void Update ()
    {
		if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
	}
    public void doquit()
    {
        Application.Quit();
    }
}
