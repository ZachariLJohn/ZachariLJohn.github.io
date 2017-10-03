using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RandomGen : MonoBehaviour {
    //Code Inspired by Jimmy Vegas https://www.youtube.com/watch?v=g_KjLe6UmXE  //
    public GameObject TextBox;

    public int Numbers;

	public void RandomGenerator ()
    {
        Numbers = Random.Range(1, 10);

        TextBox.GetComponent<Text>().text = "" + Numbers;

    }

 
    
}
