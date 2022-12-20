using System.Collections;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class Player : MonoBehaviour
    {
        private IServiceA _serviceA;
        private IPersistentService _persistentService;
        
        [Inject]
        public void Construct(IServiceA serviceA, IPersistentService persistentService)
        {
            _serviceA = serviceA;
            _persistentService = persistentService;
        }

        public IEnumerator Start()
        {
            yield return new WaitForSeconds(1f);
            _serviceA.DoSomething();
            _persistentService.DoSomething();
        }

        public void Ping()
        {
            Debug.Log("Player was pinged");
        }
    }
}