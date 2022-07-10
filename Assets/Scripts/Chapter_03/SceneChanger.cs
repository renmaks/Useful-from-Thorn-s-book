using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//Will change scene when we press space
public class SceneChanger : MonoBehaviour 
{
	//Scene number to change to
	public int DestinationScene = 0;
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			SceneManager.LoadScene("Gamemanager_02");
	}
}
