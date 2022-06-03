using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5;
    private PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    public void Update()
    {
        if (view.IsMine)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = speed * Time.deltaTime * tempVect.normalized;

            transform.position += tempVect;            
        }
    }
}
