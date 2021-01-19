using UnityEngine;


namespace CommandPattern
{
    public class ClickCommand : ICommand
    {
        private GameObject cube;
        private Color color;
        private Color previousColor;

        public ClickCommand(GameObject cube, Color color)
        {
           this.cube = cube;
           this.color = color; 
        }

        public void Execute()
        {
            previousColor = cube.GetComponent<MeshRenderer>().material.color;
            cube.GetComponent<MeshRenderer>().material.color = color;
        }

        public void Undue()
        {
            cube.GetComponent<MeshRenderer>().material.color = previousColor;
        }
    }

}