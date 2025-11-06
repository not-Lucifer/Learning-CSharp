using System;
using UnityEngine;


 public class Testingevent : MonoBehaviour
{
    public event EventHandler Onspacepressed;
    public void Start()
    {

    }   
    private void Update()
    {
        if (Input.GetKeyDown(Keycode.Space))
        {
            Onspacepressed?.Invoke(this, EventArgs.Empty);
        }
    } 
}