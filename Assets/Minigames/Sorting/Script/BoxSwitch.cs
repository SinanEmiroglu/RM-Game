﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Methodyca.Minigames.SortGame
{   public class BoxSwitch : MonoBehaviour 
    {
        public GameObject this_box;

        public bool activation;
    
    
        // For the boxes to switch layers when after drop has been triggered. 

    // Update is called once per frame
             void Update()
             {
                //swtiching the boxes
                this_box.SetActive(activation);
                


             }
        }
        
            
    }   

