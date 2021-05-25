using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoDongCong : MonoBehaviour
{
    public GameObject CanhCong;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            CanhCong.GetComponent<Animation>().Play("QuayCong");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            CanhCong.GetComponent<Animation>().Play("DongCong");
        }
    }
}
