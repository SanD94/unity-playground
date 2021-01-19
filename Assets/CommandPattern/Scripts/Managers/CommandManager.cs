using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace CommandPattern
{
    public class CommandManager : MonoBehaviour
    {
        private static CommandManager instance;
        public static CommandManager Instance
        {
            get
            {
                if (instance == null)
                    Debug.Log("The Command Manager is NULL!");
                return instance;
            }
        }
        
        private List<ICommand> commandBuffer = new List<ICommand>();
        private void Awake() {
            instance = this;
        }
        

        public void AddCommand(ICommand command)
        {
            commandBuffer.Add(command);
        }
        
        public void Play()
        {
            StartCoroutine(PlayRoutine());
        }

        IEnumerator PlayRoutine()
        {
            Debug.Log("Playing...");
            foreach(ICommand command in commandBuffer)
            {
                command.Execute();
                yield return new WaitForSeconds(1);
            }
            Debug.Log("Finished...");
        }
        
        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }
        
        public IEnumerator RewindRoutine()
        {
            foreach (var command in Enumerable.Reverse(commandBuffer))
            {
                command.Undue();
                yield return new WaitForSeconds(1);
            }
        }
        
        public void Done()
        {
            var cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
        

        public void Reset()
        {
            commandBuffer.Clear();
        }
    }

}