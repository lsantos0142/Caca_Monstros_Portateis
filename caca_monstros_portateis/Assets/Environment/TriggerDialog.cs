using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
    {
        [SerializeField] private bool triggerActive = false;
 
        public GameObject Player;
        public GameObject Panel;

        public void togglePanel()
        {
            if (Panel != null)
            {
                bool isActive = Panel.activeSelf;
                if (!isActive)
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                } else
                {
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                Panel.SetActive(!isActive);
            }
        }

        public void closePanel()
        {
            if (Panel != null)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Panel.SetActive(false);
            }
        }

        public void OnTriggerEnter(Collider Player)
        {
            if (Player.CompareTag("Player"))
            {
                triggerActive = true;
            }
        }
 
        public void OnTriggerExit(Collider Player)
        {
            if (Player.CompareTag("Player"))
            {
                triggerActive = false;
            }
        }
 
        private void Update()
        {
            if (triggerActive && Input.GetKeyDown(KeyCode.E))
            {
                togglePanel();
            }

            if (Panel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
            {
                closePanel();
            }
        }
    }