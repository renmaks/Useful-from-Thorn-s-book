using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//Will change scene when we press space
public class SceneChanger2 : MonoBehaviour
{
	//Scene number to change to
	public int DestinationScene = 0;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.N))
			SceneManager.LoadScene("Events_02");
	}
}
