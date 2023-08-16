using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	public GameObject bulletPrefab;
	void Update()
	//左を押されたら0．０１ずつ移動
	{if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.01f, 0, 0);
		}
		//左を押されたら0．０１ずつ移動
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate ( 0.01f, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bulletPrefab, transform.position, Quaternion.identity);
		}
	}
}




