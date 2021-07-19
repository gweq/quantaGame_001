using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_script : MonoBehaviour
{
    // Start is called before the first frame update
//	public int ID;
//	float coolDown = 0;
    void Start()
    {
     
    }

    

    void Update()
    {
//        if (coolDown > 0)
//	   coolDown -= Time.deltaTime;
    }
	
    private void OnTriggerEnter(Collider other) {
    
//	if (other.tag == "Player" && coolDown <= 0) 
	{
//		foreach(portal_script id in FindObjectOfType<portal_script>())
		{
//			if (id.ID == ID && id != this)
			{
//			id.coolDown = 2;
//			Vector3 position = id.gameObject.transfer.position;
//			other.gameObject.transform.position = position;
	
			}
		}
	}

    }
}
