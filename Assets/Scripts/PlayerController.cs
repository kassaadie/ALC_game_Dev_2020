﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Move the vehcle forward
		trsnsdfrom.trandslate(Vector3.forward *Time.deltTime*speed);
    }
}
