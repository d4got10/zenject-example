using System;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class PlayerPinger : MonoBehaviour
    {
        private Player _player;
        
        [Inject]
        public void Construct(Player player)
        {
            _player = player;
        }

        public IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(2f);
                _player.Ping();
            }
        }
    }
}