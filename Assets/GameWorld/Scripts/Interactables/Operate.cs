using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Methodyca.Core;
using UnityEngine.UIElements;

public class Operate : ObjectInteraction
{

    public override void InteractWithObject()
    {
        base.InteractWithObject();
        Use();
        
    }

    public override void PickUpObject()
    {
        base.PickUpObject();
        if (!canPickUp)
            print("I can only use it on the spot");
        
    }

    void Use()
    {
        print("used " + name);
    }
}
   
