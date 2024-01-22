using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;

public class NetworkmanagerUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField joinCodeInputField;



      [SerializeField ]private Button serverBtn;
      [SerializeField] private Button hostBtn;
      [SerializeField] private Button clientBtn;


      private void Awake()
      {
          serverBtn.onClick.AddListener(() =>
          {
              NetworkManager.Singleton.StartServer();
          });
          hostBtn.onClick.AddListener(() =>
          {
              NetworkManager.Singleton.StartHost();
          });
          clientBtn.onClick.AddListener(() =>
          {
              NetworkManager.Singleton.StartClient();
          });
      }

      // Update is called once per frame
      void Update()
      {

      }
}
