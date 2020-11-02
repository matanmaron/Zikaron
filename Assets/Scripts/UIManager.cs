using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zikaron.Data;

namespace Zikaron.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] Transform GameBoard = null;
        [SerializeField] GameObject CardPrefab = null;
        private List<GameObject> cards = null;

        internal void MakeCard(Card c)
        {
            cards.Add(Instantiate())
        }
    }
}