using System;
using System.Diagnostics;
using UnityEngine;

public class TestingeventSubs : Monobehaviour
{
    public void Start()
    {
        Testingevent testingevent = GetComponent<Testingevent>();
        testingevent.Onspacepressed += Testingevent_Onspacepressed;
    }

    private void Testingevent_Onspacepressed(object sender, EventArgs e)
    {
        Debug.Log("space!");
    }
}