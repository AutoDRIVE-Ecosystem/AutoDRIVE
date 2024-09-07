using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkTF : MonoBehaviour
{
    /*
    This script links the `Transform` of a specified component with another specified
    component. This includes the {X,Y,Z} position coordinates as well as {R,P,Y}
    orientation Euler angles.
    */

    public Transform ParentTF;
    public Transform ChildTF;

    void Update()
    {
        ChildTF.position = ParentTF.position;
        ChildTF.rotation = ParentTF.rotation;
    }
}
