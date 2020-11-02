using System.Collections.Generic;
using UnityEngine;
using Zikaron.Data;

namespace Zikaron.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] UIManager uiManager = null;
        [SerializeField] List<Card> cards = null;
        internal Settings settings = null;
        int CardsOnBoard = 0;

        public static GameManager Instance { get; private set; }
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }
        }

        private void Start()
        {
            settings = SettingsManager.GetSettings();
            DataManager.Cards = new List<GameObject>();
            InitGame();
        }

        private void InitGame()
        {
            foreach (var c in cards)
            {
                uiManager.MakeCard(c);
                CardsOnBoard++;
            }
        }
    }
}