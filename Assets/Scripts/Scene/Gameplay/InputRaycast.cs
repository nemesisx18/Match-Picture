using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Scene.Gameplay.Inputs
{
    public class InputRaycast : MonoBehaviour
    {
        [SerializeField] private Camera _cam;

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(_cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider == null) return;
            }
        }
    }
}