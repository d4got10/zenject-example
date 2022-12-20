namespace ExampleIOC
{
    public class Player
    {   
    }

    #region Enemy
    public class Enemy
    {
        public Enemy(Player player)
        {
        }
        
        public void Update()
        {
            //Move to Player
        }
    }
    
    //Container.Instantiate<Enemy>();
    #endregion

    #region Tutorial
    public class Tutorial
    {
        public Tutorial(Player player)
        {
            _player = player;
        }

        private readonly Player _player;

        public void Update()
        {
            //Do something with player _player
        }
    }
    #endregion

    #region IOC-Container

    public interface IMagicMachine
    {
        void Bind<TKey, TValue>(TValue value);
        TKey Resolve<TKey>();
    }

    #region Game

    public class Game
    {
        public Game()
        {
            _magicMachine = new MagicMachine();
        }

        private readonly IMagicMachine _magicMachine;

        public void Start()
        {
            var player = CreatePlayer();
            _magicMachine.Bind<Player, Player>(player);
            var enemy = CreateEnemy(); // Создается с 
        }

        #region Hidden
        private Player CreatePlayer() => null;
        private Enemy CreateEnemy() => null;
        #endregion
    }

    #endregion

    #endregion

    #region MagicMachine

    public class MagicMachine : IMagicMachine
    {
        public void Bind<TKey, TValue>(TValue value)
        {
            throw new System.NotImplementedException();
        }

        public TKey Resolve<TKey>()
        {
            throw new System.NotImplementedException();
        }
    }

    #endregion
}