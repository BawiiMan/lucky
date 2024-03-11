using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGMath : MonoBehaviour
{
    //±æÀÌ
    public static float Magnitude(Vector3 a)
    {
        //return Mathf.Sqrt(a.magnitude);
        var px = Mathf.Pow(a.x, 2);
        var py = Mathf.Pow(a.y, 2);
        var pz = Mathf.Pow(a.z, 2);

        return Mathf.Sqrt(px + py + pz);
    }

    //´ÜÀ§ º¤ÅÍ
    public static Vector3 Normalize(Vector3 a)
    {
        //var normal = a.normalized;
        var magnitude = Magnitude(a);
        return new Vector3(a.x / magnitude, a.y / magnitude, a.z / magnitude);
    }

    //µ¡¼À
    public static Vector3 Add(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    //»¬¼À
    public static Vector3 Substract(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    //½ºÄ®¶ó°ö
    public static Vector3 Scale(Vector3 a, float scalar)
    {
        return new Vector3(a.x * scalar, a.y * scalar, a.z * scalar);
    }
    //³»Àû
    public static float Dot(Vector3 a, Vector3 b)
    {
        var top = a.x * b.x + a.y * b.y + a.z * b.z;
        var px = Mathf.Pow(a.x, 2);
        var py = Mathf.Pow(a.y, 2);
        var pz = Mathf.Pow(a.z, 2);

        var qx = Mathf.Pow(b.x, 2);
        var qy = Mathf.Pow(b.y, 2);
        var qz = Mathf.Pow(b.z, 2);

        var bottom = Mathf.Sqrt(px + py + pz) * Mathf.Sqrt(qx + qy + qz);

        return Mathf.Acos(top / bottom);
    }

    //¿ÜÀû
    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        var px = a.y * b.z - a.z * b.y;
        var py = a.z * b.x - a.x * b.z;
        var pz = a.x * b.y - a.y * b.x;

        return new Vector3(px, py, pz);
    }

    public static float ThetaToRadian(float theta)
    {
        return Mathf.Acos(theta);
    }

    //¶óµð¾È º­È¯ 
    //µð±×¸® º¯È¯
    public static float RadianToDegree(float radian)
    { 
        return radian * (360 / Mathf.PI * 2);
    }

}
