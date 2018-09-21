// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using HoloToolkit.Unity.InputModule;
using UnityEngine;

    /// <summary>
    /// The Interactible class flags a Game Object as being "Interactible".
    /// Determines what happens when an Interactible is being gazed at.
    /// </summary>
    public class Clicker : MonoBehaviour, IInputClickHandler
    {
        int i = 0;
        int cnt = 6;
        
        Color[] DifferentColors = { Color.blue, Color.green, Color.yellow, Color.cyan, Color.red, Color.white };

        private void Start()
        {

            // Add a BoxCollider if the interactible does not contain one.
            Collider collider = GetComponentInChildren<Collider>();
            if (collider == null)
            {
                gameObject.AddComponent<BoxCollider>();
            }

        }

        /* TODO: DEVELOPER CODING EXERCISE 2.d */

        void IInputClickHandler.OnInputClicked(InputClickedEventData eventData)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = DifferentColors[i];
            i += 1; if (i >= cnt) i = 0;
            Debug.Log(i);
        }

    }
