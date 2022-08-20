using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSphereColor : MonoBehaviour
{
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == ("Finish"))
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            PlayerMove.Instance.isMoving = false;
            PlayerSwerve.Instance.enabled = false;
        }
    }
}
