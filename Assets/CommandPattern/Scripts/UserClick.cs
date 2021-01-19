using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class UserClick : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(rayOrigin, out hitInfo))
                {
                    if (hitInfo.collider.tag == "Cube")
                    {
                        ICommand click = new ClickCommand(
                            hitInfo.collider.gameObject,
                            new Color(Random.value, Random.value, Random.value)
                        );
                        click.Execute();
                        CommandManager.Instance.AddCommand(click);
                    }
                }
            }

        }
    }


}