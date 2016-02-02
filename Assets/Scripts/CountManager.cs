using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountManager : MonoBehaviour {

    public Text zombieCountText;
    

	// Use this for initialization
	void Start () {
        GameObject[] zombieCount=GameObject.FindGameObjectsWithTag("Zombie");
        zombieCountText.text = string.Format("{0} Zombies Left", zombieCount.Length);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        GameObject[] zombieCount = GameObject.FindGameObjectsWithTag("Zombie");
        zombieCountText.text = string.Format("{0} Zombies Left", zombieCount.Length);
    }
}
