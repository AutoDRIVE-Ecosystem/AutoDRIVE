using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TF : MonoBehaviour
{
    /*
    This script grabs the `Transform` of a specified component. This includes
    the {X,Y,Z} position coordinates as well as {R,P,Y} orientation Euler angles
    w.r.t. a parent `Transform`.
    */

    public Transform ParentTF;
    public Transform ChildTF;
    private float[] Position = new float[3];
    private float[] Orientation = new float[3];
    private Vector3 OrientationEulerAngles = new Vector3(0, 0, 0);

    public float[] CurrentPosition{get{return Position; }}
    public float[] CurrentOrientation{get{return Orientation; }}

    void FixedUpdate()
    {
        Position[0] = ChildTF.localPosition.z - ParentTF.localPosition.z;
        Position[1] = -ChildTF.localPosition.x + ParentTF.localPosition.x;
        Position[2] = ChildTF.localPosition.y - ParentTF.localPosition.y;
        // Debug.Log("Position [x: " + Position[0] + " y: " + Position[1] + " z: " + Position[2] + "]");

        OrientationEulerAngles = ChildTF.localRotation.eulerAngles - ParentTF.localRotation.eulerAngles;
        if (System.Math.Round(OrientationEulerAngles.z, 2) == 0) Orientation[0] = OrientationEulerAngles.z;
        else Orientation[0] = (360f - OrientationEulerAngles.z) * (Mathf.PI / 180);
        if (System.Math.Round(OrientationEulerAngles.x, 2) == 0) Orientation[1] = OrientationEulerAngles.x;
        else Orientation[1] = (OrientationEulerAngles.x) * (Mathf.PI / 180);
        if (System.Math.Round(OrientationEulerAngles.y, 2) == 0) Orientation[2] = OrientationEulerAngles.y;
        else Orientation[2] = (360f - OrientationEulerAngles.y) * (Mathf.PI / 180);
        // Debug.Log("Orientation [x: " + Orientation[0] + " y: " + Orientation[1] + " z: " + Orientation[2] + "]");
    }
}
