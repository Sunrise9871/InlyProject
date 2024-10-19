using System;
using UnityEngine;

namespace Player
{
    public class PlayerInput : MonoBehaviour
    {
        public event Action<int> HorizontalMove;
        public event Action<int> VerticalMove;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                HorizontalMove?.Invoke(-1);
            else if (Input.GetKeyDown(KeyCode.RightArrow))
                HorizontalMove?.Invoke(1);
            else if (Input.GetKeyDown(KeyCode.UpArrow))
                VerticalMove?.Invoke(-1);
            else if (Input.GetKeyDown(KeyCode.DownArrow))
                VerticalMove?.Invoke(1);
        }
    }
}