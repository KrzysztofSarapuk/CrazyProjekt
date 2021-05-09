using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace scripts
{
    class Licznik : MonoBehaviour
    {

        public Text uiText;
        public long score = 0;

        // Use this for initialization
        void Start()
        {
            uiText = this.GetComponent<Text>();
            UpdateScoreCounter();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void UpdateScoreCounter()
        {
            //uiText.text = "Punkty: " + score;
        }

        public void addPoints(int points)
        {
            score += points;
            UpdateScoreCounter();
        }
    }
}
